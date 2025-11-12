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
    private static Session GetSession9_1(Stats stats)
    {
        var warmup = GetSnatchWarmUp2(stats);

        var ex1Repeats = new List<Repeat>
        {
            new MultiRepeat { Percent = 0.50, Repeats = Array(1, 2), Sets = 2 },
            new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
            new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
            new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
            new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 1 },
            new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 }
        };

        ex1Repeats.AddRange(
            GetRange(0.85, 0.875, Array(1, 1), 4));

        var ex1 = new MultiSnatch(stats, ExerciseType.Snatch, HangSnatchBelowKnees)
        {
            Repeats = ex1Repeats
        };

        var ex2 = new MultiSnatch(stats, SnatchPull, HangSnatchBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.90, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.00, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.05, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(stats, KneesToElbows)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession9_2(Stats stats)
    {
        var warmup = GetCleanAndJerkWarmUp1(stats);

        var ex1 = new CleanAndJerk(stats, Clean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, CleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 3 },
                new SingleRepeat { Percent = 1.1, Repeats = 1, Sets = 1 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(warmup),
                new Round(ex1),
                new Round(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession9_3(Stats stats)
    {
        var warmup = GetSnatchWarmUp3(stats);

        var ex1 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, Jerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.750, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.900, Repeats = 2, Sets = 1 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, PushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession9_4(Stats stats)
    {
        var ex1 = new MultiSnatch(stats, PowerSnatch, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 4 }
            ]
        };

        var ex2Repeats = new List<Repeat>
        {
            new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
            new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
            new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
            new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 2 },
            new MultiRepeat { Percent = 0.80, Repeats = Array(2, 1), Sets = 2 },
            new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 2 }
        };

        ex2Repeats.AddRange(
            GetRange(0.9, 0.925, Array(1, 1), 4));

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats = ex2Repeats
        };

        var ex3 = new CleanAndJerk(stats, CleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.800, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.900, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.925, Repeats = 3, Sets = 1 }
            ]
        };

        var ex5 = new Accessory(stats, BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 5, Sets = 3 }
            ]
        };

        var ex6A = new Accessory(stats, Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60) }
            ]
        };

        var ex6B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5),
                new Round(4, ex6A, ex6B)
            ]
        };

        return session;
    }

    private static Session GetSession9_5(Stats stats)
    {
        var ex1 = new Snatch(stats, MuscleSquatSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 5 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 1, Sets = 1 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, JerkSupport)
        {
            Repeats =
            [
                new StaticRepeat { Percent = 1.1, Duration = TimeSpan.FromSeconds(6), Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }
}