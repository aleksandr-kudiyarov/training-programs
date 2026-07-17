using Kudiyarov.Packages.DoubleExtensions;
using Kudiyarov.TrainingPrograms.Dal.Interfaces;
using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using Kudiyarov.TrainingPrograms.Entities.Requests;
using Kudiyarov.TrainingPrograms.Programs;
using Microsoft.Extensions.Caching.Memory;

namespace Kudiyarov.TrainingPrograms.Bll;

public class TrainingProgramLogic
{
    private readonly IMemoryCache _memoryCache;
    private readonly IProgramRepository _repository;
    private readonly TimeSpan _cacheExpiration;

    public TrainingProgramLogic(
        IMemoryCache memoryCache,
        IProgramRepository repository)
    {
        _memoryCache = memoryCache;
        _repository = repository;
        _cacheExpiration = TimeSpan.FromMinutes(15);
    }

    public IEnumerable<TrainingProgram> Get()
    {
        var result = _repository.Get();
        return result;
    }

    public TrainingProgram GetProgram(ProgramRequest request)
    {
        var result = _repository.GetProgram(request);
        return result;
    }

    public Session GetSession(SessionRequest request)
    {
        var result = _memoryCache.GetOrCreate(request, entry =>
        {
            entry.SetSlidingExpiration(_cacheExpiration);
            return GetFromRepository(request);
        });

        return result!;
    }

    private Session GetFromRepository(SessionRequest request)
    {
        var session = _repository.GetSession(request);
        ProcessWeights(session);
        return session;
    }

    private static void ProcessWeights(Session session)
    {
        foreach (var set in session.Rounds)
        foreach (var exercise in set.Exercises)
        {
            foreach (var repeat in exercise.Repeats)
            {
                CalculatePercentage(exercise, repeat);
            }
            
            AddWarmup(exercise);
            
            foreach (var repeat in exercise.Repeats)
            {
                CalculateWeight(exercise, repeat);
            }
        }
    }

    private static void AddWarmup(BaseExercise exercise)
    {
        if (!exercise.IsWarmupNeeded)
        {
            return;
        }
        
        var lastRepeat = exercise.Repeats[^1];

        if (lastRepeat is not SingleRepeat singleRepeat || lastRepeat.Percent == null)
        {
            return;
        }
        
        var warmupPercent = singleRepeat.Percent / 2;
        var workPercent = singleRepeat.Percent;
        var sets = singleRepeat.Sets;
        var step = (workPercent - warmupPercent) / (sets - 1);

        var cnt = 0;
        var newRepeats = new Repeat[sets];
        
        foreach (var repeat in newRepeats)
        {
            var newPercent = warmupPercent + step * cnt;
            var newRepeat = singleRepeat with { Percent = newPercent, Sets = 1 };
            newRepeats[cnt] = newRepeat;
            cnt++;
        }
        
        exercise.Repeats = newRepeats;
    }

    private static void CalculatePercentage(BaseExercise exercise, Repeat repeat)
    {
        if (repeat.Weight != null || repeat.Percent != null || exercise.Weight == null)
        {
            return;
        }

        var repeats = repeat switch
        {
            SingleRepeat singleRepeat => singleRepeat.Repeats,
            MultiRepeat multiRepeat => multiRepeat.Repeats.Max(),
            _ => throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null)
        };

        var percent = GetPercent(repeats, repeat.Intensity);

        repeat.Percent = percent;
    }

    private static double GetPercent(int repeats, Intensity intensity)
    {
        var reserveRepeats = GetReserveRepeats(intensity);
        var percent = GetPercent(repeats + reserveRepeats);
        return percent;
    }

    private static double GetReserveRepeats(Intensity intensity)
    {
        var repeats = intensity switch
        {
            Intensity.None => 0,
            Intensity.Light => 5,
            Intensity.Medium => 3.5,
            Intensity.High => 1.5,
            _ => throw new ArgumentOutOfRangeException(nameof(intensity))
        };

        return repeats;
    }

    private static double GetPercent(double repeats)
    {
        var result = repeats.RelativeEquals(1)
            ? 1
            : 1 - repeats * 0.025;

        return result;
    }

    private static void CalculateWeight(BaseExercise exercise, Repeat repeat)
    {
        if (repeat.Weight == null && exercise.Weight != null)
        {
            repeat.Weight = exercise.Weight * repeat.Percent;
        }
    }
}