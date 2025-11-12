using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;

public sealed class MultiCleanAndJerk : BaseMultiExercise
{
    public MultiCleanAndJerk(
        Stats stats,
        params ExerciseType[] types) : base(stats.CleanAndJerk, types)
    {
    }

    public MultiCleanAndJerk(double weight, params ExerciseType[] types) : base(weight, types)
    {
    }
}