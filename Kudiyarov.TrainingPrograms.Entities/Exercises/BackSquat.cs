using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises;

public sealed class BackSquat : BaseSingleExercise
{
    public BackSquat(
        Stats stats,
        ExerciseType type) : base(stats.BackSquat, type)
    {
    }

    public BackSquat(double weight, ExerciseType type) : base(weight, type)
    {
    }
}