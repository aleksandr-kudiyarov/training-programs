using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Technique;

public sealed class SnatchProgram : BackTechniqueProgram
{
    public override string Name => "Snatch Program";

    protected override IReadOnlyList<Func<Stats, Session>> GetSessions()
    {
        return
        [
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4, GetSession3_5,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4, GetSession4_5,
            GetSession5_1, GetSession5_2, GetSession5_3, EmptySession, GetSession5_5
        ];
    }

    private static Session GetSession1_1(Stats stats)
    {
        var warmup = GetWarmup1(stats, 10, 15, 5);

        var ex1 = new MultiSnatch(stats, PowerSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 3 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            ]
        };

        // stats ??
        var ex4 = new Accessory(stats, SnatchPressWithRubberBand)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 6, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
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
        var warmup = GetWarmup2(stats, 15, 15);

        var ex1 = new Snatch(stats, MuscleSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 3 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 10, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession1_3(Stats stats)
    {
        var warmup = GetWarmup1(stats, 10, 15, 5);

        var ex1 = new Snatch(stats, SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 4, Sets = 3 }
            ]
        };

        var ex2 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 4 }
            ]
        };

        var ex3 = new Snatch(stats, SnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new Snatch(stats, SnatchPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession1_4(Stats stats)
    {
        var warmup = GetWarmup1(stats, 10, 15, 5);

        var ex1 = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 3 }
            ]
        };

        var ex2 = new Accessory(stats, HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, Clean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession1_5(Stats stats)
    {
        var warmup = GetWarmup2(stats, 15, 15);

        var ex1 = new MultiAccessory(SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(4, 4), Sets = 2 }
            ]
        };

        var ex2 = new MultiSnatch(stats, HipPowerSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, SnatchPushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new Snatch(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 8, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession2_1(Stats stats)
    {
        var warmup = GetWarmup2(stats, 10, 15, 5);

        var ex1 = new MultiSnatch(stats, MuscleSnatch, SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(4, 4, 4), Sets = 2 }
            ]
        };

        var ex2 = new MultiSnatch(stats, PowerSnatch, ExerciseType.Snatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1, 2), Sets = 3 }
            ]
        };

        var ex3 = new MultiSnatch(stats, ExerciseType.Snatch, HangSnatchBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.500, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.600, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.750, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.775, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.800, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex4 = new MultiSnatch(stats, SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.90, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 1.00, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.05, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex5 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 9, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 7, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 5, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession2_2(Stats stats)
    {
        var warmup = GetWarmup1(stats, 15, 15);

        var ex1 = new Snatch(stats, MuscleSquatSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 4 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, GoodMorning)
        {
            Repeats =
            [
                // stats ??
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 5, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession2_3(Stats stats)
    {
        var warmup = GetWarmup2(stats, 10, 15, 5);

        var ex1 = new Snatch(stats, HipSnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, SnatchPull, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.500, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.600, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.750, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.775, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.800, Repeats = Array(2, 1), Sets = 1 }
            ]
        };

        var ex3 = new MultiSnatch(stats, SnatchPull, HangSnatchPullAboveKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 3), Sets = 3 },
                new MultiRepeat { Percent = 1.0, Repeats = Array(1, 3), Sets = 1 }
            ]
        };

        var ex4 = new Snatch(stats, OverheadSquatPause)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession2_4(Stats stats)
    {
        var warmup = GetWarmup2(stats, 10, 15, 5);

        var ex1 = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 3 }
            ]
        };

        var ex2 = new Accessory(stats, HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 3 }
            ]
        };

        var ex3 = new MultiCleanAndJerk(stats, PowerClean, FrontSquat)
        {
            Repeats = GetRange(0.5, 0.6, Array(2, 2), 3)
        };

        var ex4 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession2_5(Stats stats)
    {
        var warmup = GetWarmup1(stats, 15, 15);

        var ex1 = new Snatch(stats, SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var ex2 = new MultiSnatch(stats, HipSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 1 }
            ]
        };

        var ex4 = new MultiSnatch(stats, SnatchPushPress, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex5 = new Accessory(stats, DeathJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 5, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession3_1(Stats stats)
    {
        var warmup = GetWarmup1(stats, 10, 15, 5);

        var ex1 = new MultiSnatch(stats, MuscleSnatch, SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(4, 4, 4), Sets = 2 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new MultiSnatch(stats, SnatchPushPress, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(3, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(3, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(3, 1), Sets = 2 }
            ]
        };

        var ex4 = new Snatch(stats, SnatchPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.70, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.10, Repeats = 1, Sets = 2 }
            ]
        };

        var ex5 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 2 }
            ]
        };

        var ex6 = new Accessory(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 8, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5),
                new Round(ex6)
            ]
        };

        return session;
    }

    private static Session GetSession3_2(Stats stats)
    {
        var warmup = GetWarmup2(stats, 15, 15);

        var ex1 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 8 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, ChickenJump)
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
                new Round(3, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession3_3(Stats stats)
    {
        var warmup = GetWarmup1(stats, 10, 15, 5);

        var ex1 = new MultiSnatch(stats, HipSnatchBalance, SotsPress)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(4, 4), Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, DeficitPowerSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, DeficitSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 3 },
                new SingleRepeat { Percent = 0.800, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.825, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.850, Repeats = 1, Sets = 1 }
            ]
        };

        var ex4 = new Snatch(stats, DeficitSnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession3_4(Stats stats)
    {
        var warmup = GetWarmup1(stats, 10, 15, 5);

        var ex1 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, Clean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession3_5(Stats stats)
    {
        var warmup = GetWarmup2(stats, 15, 15);

        var ex1 = new MultiSnatch(stats, SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(4, 4), Sets = 3 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 2 }
            ]
        };

        var ex4 = new Snatch(stats, SnatchPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 4 }
            ]
        };

        var ex5 = new Snatch(stats, SnatchPushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.95, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.05, Repeats = 1, Sets = 1 }
            ]
        };

        var ex6 = new Accessory(stats, DeathJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5),
                new Round(ex6)
            ]
        };

        return session;
    }

    private static Session GetSession4_1(Stats stats)
    {
        var warmup = GetWarmup2(stats, 15, 15, 5);

        var ex1 = new MultiSnatch(stats, MuscleSnatch, SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(3, 3, 3), Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, PowerSnatch, ExerciseType.Snatch)
        {
            Repeats = GetRange(0.5, 0.6, Array(2, 1), 3)
        };

        var ex3 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 1, Sets = 4 }
            ]
        };

        var ex4 = new MultiSnatch(stats, SnatchPullTillKnee, SnatchPullTillPower, SnatchPull)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 1.0, Repeats = Array(1, 1, 1), Sets = 3 }
            ]
        };

        var ex5 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 2 }
            ]
        };

        var ex6 = new Accessory(stats, SnatchPressWithRubberBand)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 5, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5),
                new Round(ex6)
            ]
        };

        return session;
    }

    private static Session GetSession4_2(Stats stats)
    {
        var warmup = GetWarmup1(stats, 15, 15);

        var ex1 = new Snatch(stats, MuscleSquatSnatch)
        {
            Repeats = GetRange(0.5, 0.6, 2, 3)
        };

        var ex2 = new MultiCleanAndJerk(stats, FrontSquat, Jerk)
        {
            Repeats = GetRange(0.5, 0.6, Array(2, 1), 3)
        };

        var ex3 = new Accessory(stats, BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 5, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession4_3(Stats stats)
    {
        var warmup = GetWarmup2(stats, 15, 15, 5);

        var ex1 = new Snatch(stats, HipSnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, ExerciseType.Snatch, HangSnatchBelowKnees, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1, 2), Sets = 3 }
            ]
        };

        var ex3 = new MultiSnatch(stats, ExerciseType.Snatch, HangSnatchBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.500, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.600, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.800, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.850, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.875, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.900, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex4 = new MultiSnatch(stats, SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.90, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.00, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.05, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession4_4(Stats stats)
    {
        var warmup = GetWarmup2(stats, 15, 15, 5);

        var ex1 = new MultiCleanAndJerk(stats, MuscleClean, FrontSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(4, 4), Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, PowerClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 4 },
                new SingleRepeat { Percent = 0.9, Repeats = 4 },
                new SingleRepeat { Percent = 1.0, Repeats = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession4_5(Stats stats)
    {
        var warmup = GetWarmup1(stats, 15, 15);

        var ex1 = new Snatch(stats, SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var ex2 = new Snatch(stats, DeficitPowerSnatch)
        {
            Repeats = GetRange(0.5, 0.6, 3, 3)
        };

        var ex3 = new MultiSnatch(stats, SnatchPull, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex4 = new Accessory(stats, ChickenJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 5, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession5_1(Stats stats)
    {
        var warmup = GetWarmup1(stats, 10, 15);

        var ex1 = new Snatch(stats, SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 2 }
            ]
        };

        var ex3 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 3 }
            ]
        };

        var ex4 = new MultiSnatch(stats, SnatchPullTillKnee, SnatchPullTillPower)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex5 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession5_2(Stats stats)
    {
        var warmup = GetWarmup3(stats, 10, 5);

        var ex1 = new CleanAndJerk(stats, HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 4, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession5_3(Stats stats)
    {
        var warmup = GetWarmup1(stats, 10, 15);

        var ex1 = new Snatch(stats, HipSnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 4, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, PowerSnatch, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession5_5(Stats stats)
    {
        var warmup = GetWarmup3(stats, 10, 5);

        var ex1 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.600, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.700, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.750, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.800, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.900, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.950, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.000, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.025, Repeats = 1, Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1)
            ]
        };

        return session;
    }
}