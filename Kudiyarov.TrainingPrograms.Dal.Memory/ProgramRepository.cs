using Kudiyarov.TrainingPrograms.Dal.Interfaces;
using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Requests;
using Kudiyarov.TrainingPrograms.Programs;
using Kudiyarov.TrainingPrograms.Programs.Competition;
using Kudiyarov.TrainingPrograms.Programs.Strength;
using Kudiyarov.TrainingPrograms.Programs.Technique;

namespace Kudiyarov.TrainingPrograms.Dal.Memory;

public class ProgramRepository : IProgramRepository
{
    private readonly IReadOnlyDictionary<ProgramType, TrainingProgram> _repository;

    public ProgramRepository()
    {
        var programs = new TrainingProgram[]
        {
            new CompetitionProgram(),
            new DeadliftProgram(),
            new LegsProgram(),
            new MuscleGainProgram(),
            new PullAndSquatProgram(),
            new SnatchProgram(),
            new CleanProgram(),
            new JerkProgram(),
            new SpeedProgram(),
            new BodybuildingProgram()
        };

        _repository = programs.ToDictionary(program => program.Type);
    }

    public IEnumerable<TrainingProgram> Get()
    {
        var result = _repository.Values;
        return result;
    }

    public TrainingProgram Get(ProgramType type)
    {
        var result = _repository[type];
        return result;
    }

    public Session Get(SessionRequest request)
    {
        var program = _repository[request.ProgramType];
        var session = program.Get(request.Day, request.Stats);
        return session;
    }
}