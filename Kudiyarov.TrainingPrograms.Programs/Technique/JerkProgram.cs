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

    protected override IReadOnlyList<Func<Stats, Session>> GetSessions()
    {
        Func<Stats, Session>[] sessions =
        [
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4, GetSession3_5,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4, GetSession4_5,
            GetSession5_1, GetSession5_2, GetSession5_3, EmptySession, GetSession5_5
        ];

        return sessions;
    }

    private static Session GetSession1_1(Stats stats)
    {
        var warmup = GetWarmup1(stats);

        var ex1 = new MultiCleanAndJerk(stats, FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, PushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, PressWithRubberBand)
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
        var ex1A = new Accessory(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 3 }
            ]
        };

        var ex1B = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex1C = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex1D = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            ]
        };

        var ex1E = new Accessory(stats, HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, CleanPullTillPowerPosition, MuscleSquatClean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 4 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, DeficitRomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 6 }
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
                new Round(ex1A, ex1B, ex1C, ex1D, ex1E),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
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
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var b = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, CleanStretching)
        {
            Repeats =
            [
                new MultiRepeat { Repeats = Array(20, 20), Sets = 2 }
            ]
        };

        var e = new Accessory(stats, JerkDropBalance)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[] { a, b, c, d, e };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, JerkBehindTheNeck)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new BackSquat(stats, BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
            ]
        };

        var ex5 = new CleanAndJerk(stats.PushPress, PushPress)
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
                new Round(warmup),
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
        var ex1A = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 3 }
            ]
        };

        var ex1B = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex1C = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var ex1D = new Accessory(stats, SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, SnatchPullTillPower, HangPowerSnatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 3 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, SnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.75, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 4 }
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
                new Round(ex1A, ex1B, ex1C, ex1D),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession1_5(Stats stats)
    {
        var warmup = GetWarmup1(stats);

        var ex1 = new CleanAndJerk(stats, Cluster)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 4 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, PushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.70, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 4, Sets = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, JerkSupport)
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
                new Round(warmup),
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
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var b = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var e = new Accessory(stats, HipCleanBalance)
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

        var ex1 = new MultiCleanAndJerk(stats, CleanPullTillPowerPosition, Clean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, CleanPullSlowlyDown)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, ChickenJump)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession2_2(Stats stats)
    {
        var a = new Accessory(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 3 }
            ]
        };

        var b = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 8, Sets = 2 }
            ]
        };

        var e = new MultiSnatch(stats, MuscleSnatch, SnatchBalance)
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

        var ex1 = new MultiSnatch(stats, PowerSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, Jerk)
        {
            Repeats = GetRange(0.3, 0.4, 3, 8)
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

    private static Session GetSession2_3(Stats stats)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var b = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var e = new Accessory(stats, JerkDropBalance)
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

        var ex1 = new MultiCleanAndJerk(stats, Clean, FrontSquat, Jerk)
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

        var ex2 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.65, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, JerkSupport)
        {
            Repeats = GetRange(0.9, 0.95, TimeSpan.FromSeconds(6), 6)
        };

        var ex4 = new MultiCleanAndJerk(stats, PressInSplitPosition, OverheadSplitSquat)
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
                new Round(warmup),
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
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 4 }
            ]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var e = new Accessory(stats, SnatchOnPlates)
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

        var ex1 = new MultiSnatch(stats, SnatchPullTillPower, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 6 }
            ]
        };

        var ex2 = new Accessory(stats, BoxJump)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession2_5(Stats stats)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var b = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, CleanStretching)
        {
            Repeats =
            [
                new MultiRepeat { Repeats = Array(20, 20), Sets = 2 }
            ]
        };

        var e = new Accessory(stats, JerkDropBalance)
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

        var ex1 = new CleanAndJerk(stats, Jerk)
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

        var ex2 = new BackSquat(stats, BenchBackSquat)
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

        var ex3 = new MultiCleanAndJerk(stats, PausePushPress, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.40, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 4 }
            ]
        };

        var ex4 = new Accessory(stats, BarbellSquatJump)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession3_1(Stats stats)
    {
        var a = new Accessory(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 4 }
            ]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, SotsPressPause)
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

        var ex1 = new MultiSnatch(stats, MuscleSquatSnatch, OverheadSquat)
        {
            Repeats = GetRange(0.4, 0.5, Array(3, 2), 4)
        };

        var ex2 = new CleanAndJerk(stats, Jerk)
        {
            Repeats = GetRange(0.3, 0.4, 3, 8)
        };

        var ex3 = new Accessory(stats, DeathJump)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession3_2(Stats stats)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var b = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var e = new Accessory(stats, HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var warmup = new BaseExercise[] { a, b, c, d, e };

        var ex1 = new MultiCleanAndJerk(stats, Clean, FrontSquat)
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

        var ex2 = new CleanAndJerk(stats, JerkSupport)
        {
            Repeats =
            [
                new StaticRepeat { Percent = 0.90, Duration = TimeSpan.FromSeconds(6), Sets = 2 },
                new StaticRepeat { Percent = 1.05, Duration = TimeSpan.FromSeconds(6), Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, BoxJump)
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
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession3_3(Stats stats)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var b = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, CleanStretching)
        {
            Repeats =
            [
                new MultiRepeat { Repeats = Array(20, 20), Sets = 2 }
            ]
        };

        var e = new Accessory(stats, JerkDropBalance)
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

        var ex1 = new CleanAndJerk(stats, JerkBehindTheNeck)
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

        var ex2 = new CleanAndJerk(stats, FrontSquat)
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

        var ex3 = new CleanAndJerk(stats, PushPressInSplit)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
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
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 4 }
            ]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var e = new Accessory(stats, SnatchOnPlates)
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

        var ex1 = new MultiCleanAndJerk(stats, PauseJerk, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, PauseJerkDrive, JerkDrive)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(2, 1), Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 4 }
            ]
        };

        var ex4 = new Accessory(stats, PressWithRubberBand)
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
                new Round(warmup),
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
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 4 }
            ]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var e = new Accessory(stats, SnatchOnPlates)
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

        var ex1 = new MultiSnatch(stats, PowerSnatch, ExerciseType.Snatch)
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

        var ex2 = new Snatch(stats, DeficitMediumGripPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 4 }
            ]
        };

        var ex3 = new Accessory(stats, ChickenJump)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession4_1(Stats stats)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var e = new Accessory(stats, JerkDropBalance)
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

        var ex1 = new MultiCleanAndJerk(stats, FrontSquat, Jerk)
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

        var ex2 = new CleanAndJerk(stats, Jerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(stats, PressInSplitPosition, OverheadSplitSquat)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession4_2(Stats stats)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, ElbowsRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var e = new Accessory(stats, HipCleanBalance)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var warmup = new BaseExercise[] { a, b, c, d, e };

        var ex1 = new MultiCleanAndJerk(stats, CleanPullTillPowerPosition, MuscleSquatClean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, CleanPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 }
            ]
        };

        var ex3 = new Accessory(stats, BarbellSquatJump)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession4_3(Stats stats)
    {
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 15, Sets = 2 }
            ]
        };

        var c = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, JerkDropBalance)
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

        var ex1 = new MultiCleanAndJerk(stats, PauseJerk, Jerk)
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

        var ex2 = new MultiCleanAndJerk(stats, PauseJerkDrive, JerkDrive)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 1.0, Repeats = Array(1, 1), Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, JerkSupport)
        {
            Repeats =
            [
                new StaticRepeat { Percent = 1.05, Duration = TimeSpan.FromSeconds(6), Sets = 3 },
                new StaticRepeat { Percent = 1.10, Duration = TimeSpan.FromSeconds(6), Sets = 1 }
            ]
        };

        var ex4 = new BackSquat(stats, BenchBackSquat)
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
                new Round(warmup),
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
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var c = new Accessory(stats, ElbowsRotation)
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

        var ex1 = new CleanAndJerk(stats, Cluster)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.40, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.50, Repeats = 4, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats = GetRange(0.4, 0.5, Array(2, 2), 6)
        };

        var ex3 = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Intensity = Intensity.Light, Repeats = Array(4, 4), Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, BoxJump)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession4_5(Stats stats)
    {
        var a = new Accessory(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var c = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var e = new Accessory(stats, SnatchOnPlates)
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

        var ex1 = new MultiSnatch(stats, ExerciseType.Snatch, OverheadSquat)
        {
            Repeats = GetRange(0.4, 0.5, Array(3, 1), 6)
        };

        var ex2 = new Snatch(stats, SnatchPushPress)
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

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new Snatch(stats, SotsPress)
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
                new Round(warmup),
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
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(stats, ElbowsRotation)
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

        var ex1 = new MultiCleanAndJerk(stats, Clean, FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(2, 2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1, 2), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, Jerk)
        {
            Repeats = GetEx2Repeats()
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
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

    private static Session GetSession5_2(Stats stats)
    {
        var a = new Accessory(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6, Sets = 2 }
            ]
        };

        var b = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 8, Sets = 2 }
            ]
        };

        var c = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new MultiSnatch(stats, MuscleSnatch, SnatchBalance)
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

        var ex1 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats = GetRange(0.3, 0.4, 3, 5)
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(warmup),
                new Round(ex1)
            ]
        };

        return session;
    }

    private static Session GetSession5_3(Stats stats)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 2 }
            ]
        };

        var b = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 5, Sets = 2 }
            ]
        };

        var c = new Accessory(stats, CleanStretching)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, JerkDropBalance)
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

        var ex1 = new CleanAndJerk(stats, Jerk)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 1, Sets = 2 }
            ]
        };

        var ex2 = new BackSquat(stats, ExerciseType.BackSquat)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession5_5(Stats stats)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var b = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var c = new Accessory(stats, CleanStretching)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, JerkDropBalance)
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

        var ex1 = new MultiCleanAndJerk(stats, FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, Jerk)
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
                new Round(warmup),
                new Round(ex1),
                new Round(ex2)
            ]
        };

        return session;
    }

    private static BaseExercise[] GetWarmup1(Stats stats)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 2 }
            ]
        };

        var b = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Pvc, Repeats = Array(8, 8), Sets = 2 }
            ]
        };

        var c = new Accessory(stats, SotsPressPause)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Pvc, Repeats = 6, Sets = 2 }
            ]
        };

        var d = new Accessory(stats, CleanStretching)
        {
            Repeats =
            [
                new MultiRepeat { Repeats = Array(20, 20), Sets = 2 }
            ]
        };

        var e = new Accessory(stats, JerkDropBalance)
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