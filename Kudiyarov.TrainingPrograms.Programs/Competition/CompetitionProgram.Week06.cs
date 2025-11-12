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
    private static Session GetSession6_1(Stats stats)
    {
        var warmup = GetSnatchWarmUp2(stats);

        var ex1 = new MultiSnatch(stats, ExerciseType.Snatch, HangSnatchBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.0, Repeats = Array(1, 2), Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 4 }
            ]
        };

        var ex4 = new Accessory(stats, Press)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 6, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(stats, ToesToBar)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
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

    private static Session GetSession6_2(Stats stats)
    {
        var warmup = GetCleanAndJerkWarmUp2(stats);

        var ex1 = new CleanAndJerk(stats, DeficitClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, SotsPress, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.3, Repeats = Array(4, 4), Sets = 5 }
            ]
        };

        var ex3A = new Accessory(stats, WristFlexion)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10 }
            ]
        };

        var ex3B = new Accessory(stats, WristExtension)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10 }
            ]
        };

        var ex4 = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(3, ex3A, ex3B),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession6_3(Stats stats)
    {
        var warmup = GetSnatchWarmUp3(stats);

        var ex1 = new MultiSnatch(stats, PowerSnatch, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 3 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 3 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 }
            ]
        };

        var ex3 = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Intensity = Intensity.Medium, Repeats = Array(6, 6), Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, GakkSquat)
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
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession6_4(Stats stats)
    {
        var warmup = GetCleanAndJerkWarmUp3(stats);

        var ex1 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, DeficitCleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.70, Repeats = 4 },
                new SingleRepeat { Percent = 0.80, Repeats = 4 },
                new SingleRepeat { Percent = 0.90, Repeats = 4 },
                new SingleRepeat { Percent = 1.00, Repeats = 4 },
                new SingleRepeat { Percent = 1.05, Repeats = 4 }
            ]
        };

        var ex4 = new Accessory(stats, BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(stats, Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60), Sets = 4 }
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

    private static Session GetSession6_5(Stats stats)
    {
        var ex1 = new Snatch(stats, HipSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 4 }
            ]
        };

        var ex2 = new MultiSnatch(stats, SnatchPushPress, SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2, 2), Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, SnatchPushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.95, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 1 }
            ]
        };

        var ex4 = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(stats, CalfRise)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
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
                new Round(ex5)
            ]
        };

        return session;
    }
}