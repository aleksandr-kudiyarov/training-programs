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
    private static Session GetSession2_1()
    {
        var warmup = GetSnatchWarmUp2();

        var ex1 = new Snatch(SnatchFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 5 }
            ]
        };

        var ex2 = new Snatch(SnatchPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 5, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 4 }
            ]
        };

        var ex4 = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(LegRaise)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession2_2()
    {
        var ex1 = new MultiSnatch(MuscleSquatSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.3, Repeats = Array(4, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 2), Sets = 4 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(PushPress, PowerJerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(PowerJerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(SnatchPressWithRubberBand)
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
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession2_3()
    {
        var warmup = GetCleanAndJerkWarmUp3();

        var ex1 = new MultiCleanAndJerk(Clean, HangCleanBelowKnee)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(CleanPull, HangCleanPullBelowKnee)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 3), Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(Jerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(Press)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 8, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession2_4()
    {
        var warmup = GetCleanAndJerkWarmUp2();

        var ex1 = new MultiCleanAndJerk(CleanPull, Clean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 5 }
            ]
        };

        var ex2 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(JerkSupport)
        {
            Repeats =
            [
                new StaticRepeat { Percent = 1, Duration = TimeSpan.FromSeconds(6), Sets = 6 }
            ]
        };

        var ex4 = new Accessory(BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession2_5()
    {
        var ex1 = new MultiSnatch(PowerSnatch, PowerSnatchAboveKnee, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2, 1), Sets = 5 }
            ]
        };

        var ex2 = new Snatch(DeficitSnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
            ]
        };

        var ex3 = new BackSquat(BackSquatPause)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 3 }
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
}