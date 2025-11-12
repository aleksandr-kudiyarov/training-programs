using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;

public sealed class Snatch : BaseSingleExercise
{
    public Snatch(
        Stats stats,
        ExerciseType type) : base(stats.Snatch, type)
    {
    }

    public Snatch(double? weight, ExerciseType type) : base(weight, type)
    {
    }
}