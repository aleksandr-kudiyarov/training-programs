using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Requests;
using Kudiyarov.TrainingPrograms.Programs;

namespace Kudiyarov.TrainingPrograms.Bll.Interfaces;

public interface ITrainingProgramLogic
{
    IEnumerable<TrainingProgram> Get();
    TrainingProgram GetProgram(ProgramRequest request);
    Session GetSession(SessionRequest request);
}