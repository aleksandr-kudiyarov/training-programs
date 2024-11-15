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
    private static Session GetSession7_1()
    {
        var warmup = GetSnatchWarmUp1();

        var ex1 = new Snatch(SnatchFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.700, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.900, Repeats = 1, Sets = 2 }
            ]
        };

        var ex2 = new Snatch(SnatchPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.80, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.10, Repeats = 3, Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(Plank)
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

    private static Session GetSession7_2()
    {
        var ex1 = new CleanAndJerk(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 4 }
            ]
        };

        var ex2 = new CleanAndJerk(Clean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(CleanPullSlowlyDown)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 4 }
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

    private static Session GetSession7_3()
    {
        var warmup = GetSnatchWarmUp2();

        var ex1 = new Snatch(DeficitSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(Jerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.700, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.900, Repeats = 1, Sets = 1 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6 },
                new SingleRepeat { Percent = 0.6, Repeats = 5 },
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 2 }
            ]
        };

        var ex4 = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var ex5A = new Accessory(WristFlexion)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10 }
            ]
        };

        var ex5B = new Accessory(WristExtension)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(3, ex5A, ex5B)
            ]
        };

        return session;
    }

    private static Session GetSession7_4()
    {
        var warmup = GetCleanAndJerkWarmUp1();

        var ex1 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.90, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(CleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 3, Sets = 2 }
            ]
        };

        var ex3 = new Accessory(PressWithRubberBand)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 8, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6, Sets = 3 }
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

    private static Session GetSession7_5()
    {
        var ex1 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(SnatchPushPress, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.60, Repeats = Array(3, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.90, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.95, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 1.00, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 1.05, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
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