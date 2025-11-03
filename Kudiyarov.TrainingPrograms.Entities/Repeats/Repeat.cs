namespace Kudiyarov.TrainingPrograms.Entities.Repeats;

public abstract record Repeat
{
    public double? Percent { get; set; }
    public Intensity Intensity { get; init; }
    public double? Weight { get; set; }
    public int Sets { get; init; } = 1;
}