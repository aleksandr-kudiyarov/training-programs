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
    private static Session GetSession10_1(Stats stats)
    {
        var warmup = GetSnatchWarmUp2(stats);

        var ex1 = new Snatch(stats, SnatchFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.600, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.650, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.700, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.900, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.925, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.950, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.975, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.000, Repeats = 1, Sets = 1 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, PressInSitPosition)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 6, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(stats, KneesToElbows)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
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

    private static Session GetSession10_2(Stats stats)
    {
        var warmup = GetCleanAndJerkWarmUp1(stats);

        var ex1 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.500, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.600, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.650, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.750, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.800, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.850, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.875, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, CleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 3 }
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

    private static Session GetSession10_3(Stats stats)
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
                new SingleRepeat { Percent = 0.75, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 1, Sets = 4 }
            ]
        };

        var ex2 = new MultiSnatch(stats, SnatchPushPress, OverheadSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.95, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 1, Sets = 1 }
            ]
        };

        var ex3 = new Snatch(stats, SnatchPushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 1.05, Repeats = 1 },
                new SingleRepeat { Percent = 1.10, Repeats = 1 }
            ]
        };

        var ex4 = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 3 }
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

    private static Session GetSession10_4(Stats stats)
    {
        var ex1 = new MultiSnatch(stats, PowerSnatch, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.500, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.600, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.650, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.750, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.800, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.850, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.900, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.950, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.975, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 1.000, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, CleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.900, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.925, Repeats = 2, Sets = 1 }
            ]
        };

        var ex5 = new Accessory(stats, PressWithRubberBand)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 6, Sets = 3 }
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
                new Round(3, ex6A, ex6B)
            ]
        };

        return session;
    }

    private static Session GetSession10_5(Stats stats)
    {
        var ex1 = new CleanAndJerk(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 3 }
            ]
        };

        var ex2 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats = GetRange(0.3, 0.4, 3, 6)
        };

        var ex3 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats = GetRange(0.3, 0.4, Array(2, 2), 6)
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