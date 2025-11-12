using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;

public sealed class CleanAndJerk : BaseSingleExercise
{
    public CleanAndJerk(
        Stats stats,
        ExerciseType type) : base(stats.CleanAndJerk, type)
    {
    }

    public CleanAndJerk(double weight, ExerciseType type) : base(weight, type)
    {
    }
}