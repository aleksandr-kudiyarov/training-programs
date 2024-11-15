using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Technique;

public class JerkProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.Jerk;
    public override string Name => "Jerk Program";

    protected override IReadOnlyList<Func<Session>> GetSessions()
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

    private static Session GetSession1_1()
    {
        var warmup = GetWarmup1();

        var ex1 = new MultiCleanAndJerk(FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(PushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(PressWithRubberBand)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession1_2()
    {
        var ex1A = new Accessory(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 3 }
            ]
        };

        var ex1B = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex1C = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex1D = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            ]
        };

        var ex1E = new Accessory(HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(CleanPullTillPowerPosition, MuscleSquatClean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 4 }
            ]
        };

        var ex3 = new CleanAndJerk(DeficitRomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 6 }
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
                new(ex1A, ex1B, ex1C, ex1D, ex1E),
                new(ex2),
                new(ex3),
                new(ex4)
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
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new Accessory(CleanStretching)
        {
            Repeats =
            [
                new MultiRepeat { Repeats = Array(20, 20), Sets = 2 }
            ]
        };

        var e = new Accessory(JerkDropBalance)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[] { a, b, c, d, e };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(JerkBehindTheNeck)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new BackSquat(BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
            ]
        };

        var ex5 = new CleanAndJerk(Stats.PushPress, PushPress)
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
                new(warmup),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession1_4()
    {
        var ex1A = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 3 }
            ]
        };

        var ex1B = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var ex1D = new Accessory(SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(SnatchPullTillPower, HangPowerSnatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 3 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex3 = new Snatch(SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.75, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 4 }
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
                new(ex1A, ex1B, ex1C, ex1D),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession1_5()
    {
        var warmup = GetWarmup1();

        var ex1 = new CleanAndJerk(Cluster)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 4 }
            ]
        };

        var ex2 = new CleanAndJerk(PushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.70, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 4, Sets = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(JerkSupport)
        {
            Repeats =
            [
                new StaticRepeat { Percent = 0.9, Duration = TimeSpan.FromSeconds(6), Sets = 4 }
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

    private static Session GetSession2_1()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var d = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var e = new Accessory(HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiCleanAndJerk(CleanPullTillPowerPosition, Clean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(CleanPullSlowlyDown)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(ChickenJump)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession2_2()
    {
        var a = new Accessory(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 3 }
            ]
        };

        var b = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var d = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 2 }
            ]
        };

        var e = new MultiSnatch(MuscleSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(5, 5), Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiSnatch(PowerSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(Jerk)
        {
            Repeats = GetRange(0.3, 0.4, 3, 8)
        };

        var session = new Session
        {
            Rounds =
            [
                new(warmup),
                new(ex1),
                new(ex2)
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
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var e = new Accessory(JerkDropBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiCleanAndJerk(Clean, FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.40, Repeats = Array(2, 2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(2, 1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.40, Repeats = Array(1, 1, 1), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.65, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(JerkSupport)
        {
            Repeats = GetRange(0.9, 0.95, TimeSpan.FromSeconds(6), 6)
        };

        var ex4 = new MultiCleanAndJerk(PressInSplitPosition, OverheadSplitSquat)
        {
            Repeats =
            [
                // Intensity.Light
                new MultiRepeat { Percent = 0.4, Repeats = Array(4, 4), Sets = 4 }
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
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 4 }
            ]
        };

        var b = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var e = new Accessory(SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiSnatch(SnatchPullTillPower, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 6 }
            ]
        };

        var ex2 = new Accessory(BoxJump)
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
                new(warmup),
                new(ex1),
                new(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession2_5()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(CleanStretching)
        {
            Repeats =
            [
                new MultiRepeat { Repeats = Array(20, 20), Sets = 2 }
            ]
        };

        var e = new Accessory(JerkDropBalance)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new CleanAndJerk(Jerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.40, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 }
            ]
        };

        var ex2 = new BackSquat(BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.40, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.50, Repeats = 6, Sets = 2 },
                new SingleRepeat { Percent = 0.65, Repeats = 5, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 5, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.95, Repeats = 1, Sets = 1 }
            ]
        };

        var ex3 = new MultiCleanAndJerk(PausePushPress, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.40, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 4 }
            ]
        };

        var ex4 = new Accessory(BarbellSquatJump)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession3_1()
    {
        var a = new Accessory(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 4 }
            ]
        };

        var b = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var e = new MultiAccessory(MuscleSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Repeats = Array(4, 4), Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiSnatch(MuscleSquatSnatch, OverheadSquat)
        {
            Repeats = GetRange(0.4, 0.5, Array(3, 2), 4)
        };

        var ex2 = new CleanAndJerk(Jerk)
        {
            Repeats = GetRange(0.3, 0.4, 3, 8)
        };

        var ex3 = new Accessory(DeathJump)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession3_2()
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var d = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var e = new Accessory(HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[] { a, b, c, d, e };

        var ex1 = new MultiCleanAndJerk(Clean, FrontSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 3 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(JerkSupport)
        {
            Repeats =
            [
                new StaticRepeat { Percent = 0.90, Duration = TimeSpan.FromSeconds(6), Sets = 2 },
                new StaticRepeat { Percent = 1.05, Duration = TimeSpan.FromSeconds(6), Sets = 3 }
            ]
        };

        var ex3 = new Accessory(BoxJump)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession3_3()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new Accessory(CleanStretching)
        {
            Repeats =
            [
                new MultiRepeat { Repeats = Array(20, 20), Sets = 2 }
            ]
        };

        var e = new Accessory(JerkDropBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new CleanAndJerk(JerkBehindTheNeck)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.40, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(PushPressInSplit)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3)
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
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 4 }
            ]
        };

        var b = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var e = new Accessory(SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiCleanAndJerk(PauseJerk, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(PauseJerkDrive, JerkDrive)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(2, 1), Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 4 }
            ]
        };

        var ex4 = new Accessory(PressWithRubberBand)
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
                new(warmup),
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
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 4 }
            ]
        };

        var b = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var e = new Accessory(SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.40, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 3 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 1 }
            ]
        };

        var ex2 = new Snatch(DeficitMediumGripPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 4 }
            ]
        };

        var ex3 = new Accessory(ChickenJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession4_1()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var e = new Accessory(JerkDropBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 2 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiCleanAndJerk(FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.40, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(2, 2), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(Jerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(PressInSplitPosition, OverheadSplitSquat)
        {
            Repeats =
            [
                // Intensity.Light
                new MultiRepeat { Percent = 0.4, Repeats = Array(4, 4), Sets = 4 }
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

    private static Session GetSession4_2()
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var e = new Accessory(HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var warmup = new BaseExercise[] { a, b, c, d, e };

        var ex1 = new MultiCleanAndJerk(CleanPullTillPowerPosition, MuscleSquatClean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(CleanPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 }
            ]
        };

        var ex3 = new Accessory(BarbellSquatJump)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession4_3()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new Accessory(JerkDropBalance)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d
        };

        var ex1 = new MultiCleanAndJerk(PauseJerk, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.40, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(PauseJerkDrive, JerkDrive)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 1.0, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(JerkSupport)
        {
            Repeats =
            [
                new StaticRepeat { Percent = 1.05, Duration = TimeSpan.FromSeconds(6), Sets = 3 },
                new StaticRepeat { Percent = 1.10, Duration = TimeSpan.FromSeconds(6), Sets = 1 }
            ]
        };

        var ex4 = new BackSquat(BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
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

    private static Session GetSession4_4()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var c = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        var ex1 = new CleanAndJerk(Cluster)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.40, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.50, Repeats = 4, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = GetRange(0.4, 0.5, Array(2, 2), 6)
        };

        var ex3 = new Accessory(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Intensity = Intensity.Light, Repeats = Array(4, 4), Sets = 3 }
            ]
        };

        var ex4 = new Accessory(BoxJump)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession4_5()
    {
        var a = new Accessory(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var c = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 2 }
            ]
        };

        var d = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var e = new Accessory(SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 4, Sets = 2 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        var ex1 = new MultiSnatch(ExerciseType.Snatch, OverheadSquat)
        {
            Repeats = GetRange(0.4, 0.5, Array(3, 1), 6)
        };

        var ex2 = new Snatch(SnatchPushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 1 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new Snatch(SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 6, Sets = 3 }
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

    private static Session GetSession5_1()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b
        };

        var ex1 = new MultiCleanAndJerk(Clean, FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(2, 2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1, 2), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(Jerk)
        {
            Repeats = GetEx2Repeats()
        };

        var ex3 = new CleanAndJerk(FrontSquat)
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
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            ]
        };

        return session;

        IReadOnlyList<Repeat> GetEx2Repeats()
        {
            var repeatsA = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 1, Sets = 1 }
            };

            var repeatsB = GetRange(0.8, 0.85, 1, 4);

            var ex2Reps = repeatsA
                .Concat(repeatsB)
                .ToArray();

            return ex2Reps;
        }
    }

    private static Session GetSession5_2()
    {
        var a = new Accessory(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6, Sets = 2 }
            ]
        };

        var b = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 2 }
            ]
        };

        var c = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new MultiSnatch(MuscleSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(3, 3), Sets = 2 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d
        };

        var ex1 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = GetRange(0.3, 0.4, 3, 5)
        };

        var session = new Session
        {
            Rounds =
            [
                new(warmup),
                new(ex1)
            ]
        };

        return session;
    }

    private static Session GetSession5_3()
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 5, Sets = 2 }
            ]
        };

        var c = new Accessory(CleanStretching)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var d = new Accessory(JerkDropBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d
        };

        var ex1 = new CleanAndJerk(Jerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 1, Sets = 2 }
            ]
        };

        var ex2 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(warmup),
                new(ex1),
                new(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession5_5()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var b = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var c = new Accessory(CleanStretching)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var d = new Accessory(JerkDropBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d
        };

        var ex1 = new MultiCleanAndJerk(FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(Jerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.700, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.750, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.800, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.850, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.900, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.950, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.975, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.000, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.025, Repeats = 1, Sets = 1 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(warmup),
                new(ex1),
                new(ex2)
            ]
        };

        return session;
    }

    private static BaseExercise[] GetWarmup1()
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var b = new Accessory(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new Accessory(CleanStretching)
        {
            Repeats =
            [
                new MultiRepeat { Repeats = Array(20, 20), Sets = 2 }
            ]
        };

        var e = new Accessory(JerkDropBalance)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c, d, e
        };

        return warmup;
    }
}