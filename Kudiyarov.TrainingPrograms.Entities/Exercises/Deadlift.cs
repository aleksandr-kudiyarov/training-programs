using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises;

public sealed class Deadlift : BaseSingleExercise
{
    public Deadlift(
        Stats stats,
        ExerciseType type) : base(stats.Deadlift, type)
    {
    }

    public Deadlift(double weight, ExerciseType type) : base(weight, type)
    {
    }
}