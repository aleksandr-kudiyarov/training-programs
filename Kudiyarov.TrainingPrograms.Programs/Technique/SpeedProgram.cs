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

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        return 
        [
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4, GetSession3_5,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4, GetSession4_5,
            GetSession5_1, GetSession5_2, GetSession5_3, GetSession5_4, GetSession5_5
        ];
    }

    private static Session GetSession1_1()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6 }
            ]
        };

        var c = new MultiSnatch(MuscleSnatch, OverheadSquat)
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

        var ex1 = new MultiSnatch(PowerSnatch, SnatchBalance)
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

        var ex2 = new Snatch(SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession1_2()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var c = new CleanAndJerk(HipCleanBalance)
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

        var ex1 = new MultiCleanAndJerk(CleanFromBlocks, FrontSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(CleanPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new Accessory(PressWithRubberBand)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession1_3()
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Snatch(SnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var c = new Snatch(SnatchOnPlates)
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

        var ex1 = new MultiSnatch(ExerciseType.Snatch, HangSnatchAboveKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex2 = new Snatch(DeficitSnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
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

        var ex4 = new Accessory(DeathJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession1_4()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var c = new MultiCleanAndJerk(MuscleClean, Press)
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

        var ex1 = new CleanAndJerk(PowerClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(FrontSquat, Jerk)
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

        var ex3 = new BackSquat(BackSquatPause)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession1_5()
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var c = new Snatch(HipSnatchBalance)
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

        var ex1 = new MultiSnatch(HipSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 2), Sets = 10 }
            ]
        };

        var ex2 = new Accessory(BarbellSquatJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession2_1()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var c = new MultiSnatch(MuscleSnatch, OverheadSquat)
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

        var ex1 = new MultiSnatch(HipPowerSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 2), Sets = 3 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(SnatchPullTillKnee, SnatchPullTillPower, SnatchPull)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 1, 1), Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession2_2()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var c = new CleanAndJerk(HipCleanBalance)
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

        var ex1 = new MultiCleanAndJerk(PowerClean, HangPowerClean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(DeficitCleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(ChickenJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession2_3()
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Snatch(SnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var c = new Snatch(SnatchOnPlates)
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

        var ex1 = new Snatch(SnatchFromBlocks)
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

        var ex2 = new MultiCleanAndJerk(PauseJerk, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 }
            ]
        };

        var ex4 = new Accessory(BarbellSquatJump)
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
                new(2, warmup),
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
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var c = new MultiCleanAndJerk(MuscleClean, FrontSquat)
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

        var ex1 = new CleanAndJerk(CleanFromBlocks)
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

        var ex2 = new CleanAndJerk(CleanPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.05, Repeats = 1, Sets = 1 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
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

        var ex4 = new Accessory(DeathJump)
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
                new(2, warmup),
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
        var a = new Accessory(WallSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var b = new Accessory(SotsPress)
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

        var ex1 = new CleanAndJerk(Jerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 10 }
            ]
        };

        var ex2A = new Accessory(HalfSquat)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(20) }
            ]
        };

        var ex2B = new Accessory(KoreanJump)
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
                new(2, warmup),
                new(ex1),
                new(2, ex2A, ex2B)
            ]
        };

        return session;
    }

    private static Session GetSession3_1()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var c = new MultiSnatch(HipSnatchBalance, SotsPress)
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

        var ex1 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch, SnatchBalance)
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

        var ex2 = new Snatch(DeficitSnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession3_2()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(DeathJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6 }
            ]
        };

        var c = new CleanAndJerk(HipCleanBalance)
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

        var ex1 = new MultiCleanAndJerk(Clean, HangCleanBelowKnee)
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

        var ex2 = new MultiCleanAndJerk(PushPress, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 3 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex3A = new Accessory(HalfSquat)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            ]
        };

        var ex3B = new Accessory(KoreanJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(2, ex3A, ex3B)
            ]
        };

        return session;
    }

    private static Session GetSession3_3()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var b = new Accessory(SnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var c = new CleanAndJerk(SnatchOnPlates)
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

        var ex1 = new MultiSnatch(HangSnatchAboveKnees, HangSnatchBelowKnees)
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

        var ex2 = new Snatch(SnatchPullFromBlocks)
        {
            Repeats = GetRange(0.5, 0.7, 3, 4)
        };

        var ex3 = new CleanAndJerk(FrontSquat)
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

        var ex4 = new Accessory(DeathJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession3_4()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var c = new MultiCleanAndJerk(MuscleClean, FrontSquat, PressInSitPosition)
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

        var ex1 = new MultiCleanAndJerk(PowerClean, Jerk)
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

        var ex2 = new CleanAndJerk(CleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new BackSquat(BackSquatPause)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(BarbellSquatJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession3_5()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6 }
            ]
        };

        var c = new Accessory(ElbowsRotation)
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

        var ex1 = new CleanAndJerk(Clean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 10 }
            ]
        };

        var ex2 = new Snatch(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 6, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(ChickenJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession4_1()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var c = new MultiSnatch(MuscleSquatSnatch, SnatchBalance)
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

        var ex1 = new MultiSnatch(ExerciseType.Snatch, PowerSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1, 1), Sets = 3 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1, 1), Sets = 1 }
            ]
        };

        var ex2 = new Snatch(SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.05, Repeats = 1, Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession4_2()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var c = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10 }
            ]
        };

        var d = new Accessory(HipCleanBalance)
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

        var ex1 = new CleanAndJerk(CleanFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(CleanPullFromBlocks)
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
                new(2, warmup),
                new(ex1),
                new(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession4_3()
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new Accessory(HipSnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var c = new CleanAndJerk(SnatchOnPlates)
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

        var ex1 = new Snatch(DeficitPowerSnatch)
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

        var ex2 = new CleanAndJerk(PauseJerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
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

        var ex4 = new Accessory(BarbellSquatJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession4_4()
    {
        var a = new Accessory(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var c = new MultiCleanAndJerk(MuscleClean, FrontSquat, PressInSitPosition)
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

        var ex1 = new MultiCleanAndJerk(PowerClean, HangPowerClean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 2), Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(FrontSquat, PushPress)
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

        var ex3 = new Accessory(DeathJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession4_5()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var c = new MultiSnatch(MuscleSnatch, SnatchBalance)
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

        var ex1 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 10 }
            ]
        };

        var ex2A = new Accessory(HalfSquat)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            ]
        };

        var ex2B = new Accessory(KoreanJump)
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
                new(2, warmup),
                new(ex1),
                new(3, ex2A, ex2B)
            ]
        };

        return session;
    }

    private static Session GetSession5_1()
    {
        var a = new Accessory(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 4 }
            ]
        };

        var c = new MultiSnatch(MuscleSquatSnatch, SotsPress)
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

        var ex1 = new MultiSnatch(ExerciseType.Snatch, SnatchBalance)
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

        var ex2 = new Snatch(SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 1, Sets = 1 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession5_2()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var c = new CleanAndJerk(MuscleSquatClean)
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

        var ex1 = new CleanAndJerk(PowerClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            ]
        };

        var ex2A = new Accessory(HalfSquat)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            ]
        };

        var ex2B = new Accessory(KoreanJump)
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
                new(2, warmup),
                new(ex1),
                new(3, ex2A, ex2B)
            ]
        };

        return session;
    }

    private static Session GetSession5_3()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var b = new Accessory(HipSnatchBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var c = new CleanAndJerk(SnatchOnPlates)
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

        var ex1 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
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

        var ex2 = new CleanAndJerk(FrontSquat)
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

        var ex3 = new Accessory(ChickenJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession5_4()
    {
        var a = new Accessory(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8 }
            ]
        };

        var b = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8 }
            ]
        };

        var c = new MultiCleanAndJerk(MuscleClean, FrontSquat, PressInSitPosition)
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

        var ex1 = new MultiCleanAndJerk(Clean, Jerk)
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

        var ex2 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(DeathJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession5_5()
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var b = new MultiSnatch(HipSnatchBalance, SotsPress)
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

        var ex1 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1, 1), Sets = 3 }
            ]
        };

        var ex2 = new Accessory(BarbellSquatJump)
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
                new(2, warmup),
                new(ex1),
                new(ex2)
            ]
        };

        return session;
    }
}