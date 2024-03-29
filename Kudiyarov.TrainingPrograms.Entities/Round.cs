using Kudiyarov.TrainingPrograms.Entities.Exercises;

namespace Kudiyarov.TrainingPrograms.Entities;

public class Round
{
    // TODO split to single-multi
    public Round(params BaseExercise[] exercises) : this(1, exercises)
    {
    }

    public Round(int rounds, params BaseExercise[] exercises)
    {
        Rounds = rounds;
        Exercises = exercises;
    }

    public int Rounds { get; }
    public IReadOnlyList<BaseExercise> Exercises { get; }
}