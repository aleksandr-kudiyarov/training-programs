using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Repeats;

namespace Kudiyarov.TrainingPrograms.Programs;

public abstract class TrainingProgram
{
    protected static readonly Func<Stats, Session> EmptySession;
    private readonly Lazy<IReadOnlyList<Func<Stats, Session>>> _sessions;

    static TrainingProgram()
    {
        EmptySession = GetEmptySession;
    }

    protected TrainingProgram()
    {
        _sessions = new Lazy<IReadOnlyList<Func<Stats, Session>>>(GetSessions);
    }

    private IReadOnlyList<Func<Stats, Session>> Sessions => _sessions.Value;

    public abstract string Name { get; }
    public int Days => Sessions.Count;
    protected abstract IReadOnlyList<Func<Stats, Session>> GetSessions();

    public Session Get(int day, Stats stats)
    {
        var index = day - 1;
        var func = Sessions[index];
        var result = func(stats);
        result.Day = day;
        return result;
    }

    protected static T[] Array<T>(params T[] value)
    {
        return value;
    }

    private static Session GetEmptySession(Stats stats)
    {
        return new Session();
    }

    protected static IReadOnlyList<Repeat> GetRange(double start, double stop, int repeats, int sets)
    {
        var result = GetRange(start, stop, Func, sets);
        return result;

        Repeat Func(double percent)
        {
            return new SingleRepeat { Percent = percent, Repeats = repeats };
        }
    }

    protected static IReadOnlyList<Repeat> GetRange(double start, double stop, IReadOnlyList<int> repeats, int sets)
    {
        var result = GetRange(start, stop, Func, sets);
        return result;

        Repeat Func(double percent)
        {
            return new MultiRepeat { Percent = percent, Repeats = repeats };
        }
    }

    protected static IReadOnlyList<Repeat> GetRange(double start, double stop, TimeSpan duration, int sets)
    {
        var result = GetRange(start, stop, Func, sets);
        return result;

        Repeat Func(double percent)
        {
            return new StaticRepeat { Percent = percent, Duration = duration };
        }
    }

    private static IReadOnlyList<Repeat> GetRange(double start, double stop, Func<double, Repeat> func, int sets)
    {
        var result = new Repeat[sets];
        var step = GetStep(start, stop, sets);

        for (var i = 0; i < sets; i++)
        {
            var percent = GetPercent(start, step, i);
            result[i] = func(percent);
        }

        return result;
    }

    private static double GetStep(double start, double stop, int sets)
    {
        var diff = stop - start;
        var steps = sets - 1;
        var result = diff / steps;
        return result;
    }

    private static double GetPercent(double start, double step, int i)
    {
        var result = start + step * i;
        return result;
    }
}