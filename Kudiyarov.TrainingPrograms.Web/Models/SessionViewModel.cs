using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Web.Models;

public class SessionViewModel
{
    public Session Session { get; set; } = null!;
    public string ProgramName { get; set; } = string.Empty;
    public ProgramType ProgramType { get; set; }
}
