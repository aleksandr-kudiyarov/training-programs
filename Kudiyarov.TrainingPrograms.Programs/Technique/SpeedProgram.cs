using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Technique;

public class SpeedProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.Speed;
    public override string Name => "Speed Cycle";

    protected override IReadOnlyList<Func<Stats, Session>> GetSessions()
    {
        Func<Stats, Session>[] sessions =
        [
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4, GetSession3_5,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4, GetSession4_5,
            GetSession5_1, GetSession5_2, GetSession5_3, GetSession5_4, GetSession5_5
        ];

        return sessions;
    }

    private static Session GetSession1_1(Stats stats)
    {
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6 }
            ]
        };

        var c = new MultiSnatch(stats, MuscleSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(6, 6) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(stats, PowerSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 1 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 }
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

    private static Session GetSession1_2(Stats stats)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var c = new CleanAndJerk(stats, HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiCleanAndJerk(stats, CleanFromBlocks, FrontSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, CleanPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new Accessory(stats, PressWithRubberBand)
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
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Snatch(stats, SnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var c = new Snatch(stats, SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(stats, ExerciseType.Snatch, HangSnatchAboveKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex2 = new Snatch(stats, DeficitSnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new Accessory(stats, DeathJump)
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
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession1_4(Stats stats)
    {
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var c = new MultiCleanAndJerk(stats, MuscleClean, Press)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(6, 6) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new CleanAndJerk(stats, PowerClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 2), Sets = 1 }
            ]
        };

        var ex3 = new BackSquat(stats, BackSquatPause)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
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

    private static Session GetSession1_5(Stats stats)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var c = new Snatch(stats, HipSnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(stats, HipSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 2), Sets = 10 }
            ]
        };

        var ex2 = new Accessory(stats, BarbellSquatJump)
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
                new Round(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession2_1(Stats stats)
    {
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var c = new MultiSnatch(stats, MuscleSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(6, 6) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(stats, HipPowerSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 2), Sets = 3 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, SnatchPullTillKnee, SnatchPullTillPower, SnatchPull)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 1, 1), Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 1 }
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

    private static Session GetSession2_2(Stats stats)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var c = new CleanAndJerk(stats, HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiCleanAndJerk(stats, PowerClean, HangPowerClean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, DeficitCleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, ChickenJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
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

    private static Session GetSession2_3(Stats stats)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Snatch(stats, SnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var c = new Snatch(stats, SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new Snatch(stats, SnatchFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, PauseJerk, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 }
            ]
        };

        var ex4 = new Accessory(stats, BarbellSquatJump)
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
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var c = new MultiCleanAndJerk(stats, MuscleClean, FrontSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(6, 6) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new CleanAndJerk(stats, CleanFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, CleanPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.05, Repeats = 1, Sets = 1 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 1 }
            ]
        };

        var ex4 = new Accessory(stats, DeathJump)
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
        var a = new Accessory(stats, WallSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var b = new Accessory(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b
        };

        var ex1 = new CleanAndJerk(stats, Jerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 10 }
            ]
        };

        var ex2A = new Accessory(stats, HalfSquat)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(20) }
            ]
        };

        var ex2B = new Accessory(stats, KoreanJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(2, ex2A, ex2B)
            ]
        };

        return session;
    }

    private static Session GetSession3_1(Stats stats)
    {
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var c = new MultiSnatch(stats, HipSnatchBalance, SotsPress)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(6, 6) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(stats, PowerSnatch, ExerciseType.Snatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(1, 2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1, 1), Sets = 1 }
            ]
        };

        var ex2 = new Snatch(stats, DeficitSnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 2 }
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

    private static Session GetSession3_2(Stats stats)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, DeathJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6 }
            ]
        };

        var c = new CleanAndJerk(stats, HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiCleanAndJerk(stats, Clean, HangCleanBelowKnee)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, PushPress, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 3 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex3A = new Accessory(stats, HalfSquat)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            ]
        };

        var ex3B = new Accessory(stats, KoreanJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(2, ex3A, ex3B)
            ]
        };

        return session;
    }

    private static Session GetSession3_3(Stats stats)
    {
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, SnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var c = new CleanAndJerk(stats, SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(stats, HangSnatchAboveKnees, HangSnatchBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchPullFromBlocks)
        {
            Repeats = GetRange(0.5, 0.7, 3, 4)
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.95, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 1 }
            ]
        };

        var ex4 = new Accessory(stats, DeathJump)
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
                new Round(2, warmup),
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
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var c = new MultiCleanAndJerk(stats, MuscleClean, FrontSquat, PressInSitPosition)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(4, 4, 4) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiCleanAndJerk(stats, PowerClean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, CleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new BackSquat(stats, BackSquatPause)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
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

    private static Session GetSession3_5(Stats stats)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6 }
            ]
        };

        var c = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new CleanAndJerk(stats, Clean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 10 }
            ]
        };

        var ex2 = new Snatch(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 6, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, ChickenJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
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

    private static Session GetSession4_1(Stats stats)
    {
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var c = new MultiSnatch(stats, MuscleSquatSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(6, 6) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(stats, ExerciseType.Snatch, PowerSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1, 1), Sets = 3 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1, 1), Sets = 1 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.05, Repeats = 1, Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.95, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 1 }
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

    private static Session GetSession4_2(Stats stats)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var c = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10 }
            ]
        };

        var d = new Accessory(stats, HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d
        };

        var ex1 = new CleanAndJerk(stats, CleanFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, CleanPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.1, Repeats = 1, Sets = 1 }
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

    private static Session GetSession4_3(Stats stats)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(stats, HipSnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var c = new CleanAndJerk(stats, SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new Snatch(stats, DeficitPowerSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 1, Sets = 1 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, PauseJerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 1 }
            ]
        };

        var ex4 = new Accessory(stats, BarbellSquatJump)
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
                new Round(2, warmup),
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
        var a = new Accessory(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var c = new MultiCleanAndJerk(stats, MuscleClean, FrontSquat, PressInSitPosition)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(4, 4, 4) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiCleanAndJerk(stats, PowerClean, HangPowerClean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 2), Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, FrontSquat, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.500, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.600, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.725, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.750, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.800, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex3 = new Accessory(stats, DeathJump)
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
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession4_5(Stats stats)
    {
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var c = new MultiSnatch(stats, MuscleSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(6, 6) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 10 }
            ]
        };

        var ex2A = new Accessory(stats, HalfSquat)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            ]
        };

        var ex2B = new Accessory(stats, KoreanJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(3, ex2A, ex2B)
            ]
        };

        return session;
    }

    private static Session GetSession5_1(Stats stats)
    {
        var a = new Accessory(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 4 }
            ]
        };

        var c = new MultiSnatch(stats, MuscleSquatSnatch, SotsPress)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(6, 6) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(stats, ExerciseType.Snatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.90, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 1, Sets = 1 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 1 }
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

    private static Session GetSession5_2(Stats stats)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var c = new CleanAndJerk(stats, MuscleSquatClean)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new CleanAndJerk(stats, PowerClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            ]
        };

        var ex2A = new Accessory(stats, HalfSquat)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            ]
        };

        var ex2B = new Accessory(stats, KoreanJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, warmup),
                new Round(ex1),
                new Round(3, ex2A, ex2B)
            ]
        };

        return session;
    }

    private static Session GetSession5_3(Stats stats)
    {
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, HipSnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var c = new CleanAndJerk(stats, SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiSnatch(stats, PowerSnatch, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.500, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.600, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.750, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.800, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.850, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.875, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 1 }
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
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession5_4(Stats stats)
    {
        var a = new Accessory(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var c = new MultiCleanAndJerk(stats, MuscleClean, FrontSquat, PressInSitPosition)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(4, 4, 4) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.90, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex2 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, DeathJump)
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
                new Round(2, warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession5_5(Stats stats)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new MultiSnatch(stats, HipSnatchBalance, SotsPress)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(4, 4) }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b
        };

        var ex1 = new MultiSnatch(stats, PowerSnatch, ExerciseType.Snatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1, 1), Sets = 3 }
            ]
        };

        var ex2 = new Accessory(stats, BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 3 }
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
}