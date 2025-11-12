using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;

public sealed class MultiSnatch : BaseMultiExercise
{
    public MultiSnatch(
        Stats stats,
        params ExerciseType[] types) : base(stats.Snatch, types)
    {
    }

    public MultiSnatch(double weight, params ExerciseType[] types) : base(weight, types)
    {
    }
}