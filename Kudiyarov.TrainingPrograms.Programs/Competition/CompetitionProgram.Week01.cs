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
    private static Session GetSession1_1(Stats stats)
    {
        var warmup = GetSnatchWarmUp1(stats);

        var ex1 = new MultiSnatch(stats, HangSnatchBelowKnees, HangSnatchAboveKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 4 }
            ]
        };

        var ex2 = new MultiSnatch(stats, SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 3), Sets = 4 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 5, Sets = 4 }
            ]
        };

        var ex4 = new Accessory(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12, Sets = 3 }
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

    private static Session GetSession1_2(Stats stats)
    {
        var ex1 = new MultiSnatch(stats, MuscleSquatSnatch, OverheadSquat)
        {
            Repeats = GetRange(0.3, 0.35, Array(4, 4), 4)
        };

        var ex2 = new CleanAndJerk(stats, DeficitRomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 6, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, PushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 5 }
            ]
        };

        var ex4 = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 3 }
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

    private static Session GetSession1_3(Stats stats)
    {
        var warmup = GetCleanAndJerkWarmUp3(stats);

        var ex1 = new CleanAndJerk(stats, CleanFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, CleanPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 }
            ]
        };

        var ex3 = new MultiCleanAndJerk(stats, FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, CalfRise)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
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

    private static Session GetSession1_4(Stats stats)
    {
        var warmup = GetCleanAndJerkWarmUp1(stats);

        var ex1 = new MultiCleanAndJerk(stats, PowerClean, PowerCleanBelowKnee)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 5 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, DeficitCleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, SnatchPushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 4 }
            ]
        };

        var ex5A = new Accessory(stats, WristFlexion)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10 }
            ]
        };

        var ex5B = new Accessory(stats, WristExtension)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10 }
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
                new Round(2, ex5A, ex5B)
            ]
        };

        return session;
    }

    private static Session GetSession1_5(Stats stats)
    {
        var ex1 = new MultiSnatch(stats, PowerSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 4 }
            ]
        };

        var ex2 = new Snatch(stats, MediumGripPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
            ]
        };

        var ex3 = new BackSquat(stats, BackSquatNarrowFeet)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 4 }
            ]
        };

        var ex4 = new Snatch(stats, SnatchPressWithRubberBand)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(stats, Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(45), Sets = 4 }
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