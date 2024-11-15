using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Competition;

public sealed partial class CompetitionProgram
{
    private static Session GetSession12_1()
    {
        var ex1 = new Snatch(PowerSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 1, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession12_3()
    {
        var ex1 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 1 }
            ]
        };

        var ex3 = new CleanAndJerk(CleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.95, Repeats = 2, Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession12_4()
    {
        var ex1 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 1, Sets = 1 }
            ]
        };

        var ex2 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession12_5()
    {
        var ex1 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = GetRange(0.3, 0.4, 3, 6)
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = GetRange(0.3, 0.4, Array(2, 2), 6)
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2)
            ]
        };

        return session;
    }
}