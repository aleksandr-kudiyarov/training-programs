using System.Collections.Frozen;
using Kudiyarov.TrainingPrograms.Dal.Interfaces;
using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Requests;
using Kudiyarov.TrainingPrograms.Programs;

namespace Kudiyarov.TrainingPrograms.Dal.Memory;

public class ProgramRepository : IProgramRepository
{
    private readonly FrozenDictionary<string, TrainingProgram> _repository;

    public ProgramRepository(IEnumerable<TrainingProgram> programs)
    {
        _repository = programs.ToFrozenDictionary(program => program.Name);
    }

    public IEnumerable<TrainingProgram> Get()
    {
        var result = _repository.Values;
        return result;
    }

    public TrainingProgram GetProgram(ProgramRequest request)
    {
        var result = _repository[request.ProgramName];
        return result;
    }

    public Session GetSession(SessionRequest request)
    {
        var program = _repository[request.ProgramName];
        var session = program.Get(request.Day, request.Stats);
        return session;
    }
}
