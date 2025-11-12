using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs;

public sealed class BodybuildingProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.Bodybuilding;
    public override string Name => "Bodybuilding Program";

    protected override IReadOnlyList<Func<Stats, Session>> GetSessions()
    {
        return
        [
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4
        ];
    }

    private static Session GetSession1_1(Stats stats)
    {
        var ex1A = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };
        
        var ex1B = new Accessory(stats, Superman)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };
        
        var ex1C = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };
        
        var ex1D = new Accessory(stats, LuRaises)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };
        
        var ex2 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 8, Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(stats.BenchBackSquat, BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Intensity = Intensity.Light, Repeats = [15, 15], Sets = 2 }
            ]
        };

        var ex5 = new Accessory(stats, CalfRise)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var ex6 = new CleanAndJerk(stats.PushPress, PushPress)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 8, Sets = 3 }
            ]
        };

        var ex7 = new Accessory(stats, Press)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            ]
        };

        var ex8 = new Accessory(stats, ReverseFly)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var ex9 = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex10 = new Accessory(stats, Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(45), Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, ex1A, ex1B, ex1C, ex1D),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5),
                new Round(ex6),
                new Round(ex7),
                new Round(ex8),
                new Round(ex9),
                new Round(ex10)
            ]
        };

        return session;
    }

    private static Session GetSession1_2(Stats stats)
    {
        var ex1A = new Accessory(stats, PushUp)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(stats, ReversePushUp)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new Accessory(stats, BenchPress)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, InclineBenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, SeatedBenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 25, Sets = 2 }
            ]
        };

        var ex5 = new Accessory(stats, FrenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            ]
        };

        var ex6A = new Accessory(stats, TricepsExtension)
        {
            Repeats =
            [
                new MultiRepeat { Repeats = [20, 20] }
            ]
        };

        var ex6B = new Accessory(stats, MilitaryPlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5),
                new Round(2, ex6A, ex6B)
            ]
        };

        return session;
    }

    private static Session GetSession1_3(Stats stats)
    {
        var ex = new MultiSnatch(stats, PowerSnatch, ExerciseType.Snatch)
        {
            Repeats = GetRange(0.5, 0.6, [2, 2], 6)
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(ex)
            ]
        };

        return session;
    }

    private static Session GetSession1_4(Stats stats)
    {
        var ex1 = new Deadlift(stats.SnatchDeadlift, SnatchDeadlift)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new Deadlift(stats.RomanianDeadlift, RomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, LateralPull)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, BicepsCurl)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(stats, WristFlexion)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 2 }
            ]
        };

        var ex6 = new Accessory(stats, DiscJuggling)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 30, Sets = 2 }
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
                new Round(ex6)
            ]
        };

        return session;
    }

    private static Session GetSession2_1(Stats stats)
    {
        var ex1A = new Accessory(stats, SupermanCrossed)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };
        
        var ex1B = new Accessory(stats, GluteBridge)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };
        
        var ex1C = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };
        
        var ex1D = new Accessory(stats, LuRaises)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };
        
        var ex1 = new CleanAndJerk(stats, FrontSquat)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.High, Repeats = 6, Sets = 3 }
            ]
        };

        var ex2 = new BackSquat(stats.BenchBackSquat, BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, ForwardLunges)
        {
            Repeats =
            [
                new MultiRepeat { Intensity = Intensity.Light, Repeats = [12, 12], Sets = 3 }
            ]
        };

        var ex4 = new Snatch(stats, SnatchPushPress)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10, Sets = 3 }
            ]
        };
        
        var ex5 = new Accessory(stats, AsymmetryPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 4 }
            ]
        };

        var ex6A = new Accessory(stats, LateralRaise)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex6B = new Accessory(stats, DiscPress)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex7 = new Accessory(stats, ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(45), Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B, ex1C, ex1D),
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5),
                new Round(2, ex6A, ex6B),
                new Round(ex7)
            ]
        };

        return session;
    }

    private static Session GetSession2_2(Stats stats)
    {
        var ex1A = new Accessory(stats, WidePushUp)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(stats, SeatedBenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex2 = new Accessory(stats, BenchPress)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.High, Repeats = 10, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, AsymmetryBenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 4 }
            ]
        };

        var ex4 = new Accessory(stats, InclineBenchPressNarrowGrip)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(stats, FrenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 20, Sets = 4 }
            ]
        };

        var ex6A = new Accessory(stats, TricepsExtension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 30 }
            ]
        };

        var ex6B = new Accessory(stats, ReversePushUp)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5),
                new Round(2, ex6A, ex6B)
            ]
        };

        return session;
    }

    private static Session GetSession2_3(Stats stats)
    {
        var ex = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats = GetRange(0.5, 0.6, [2, 2], 6)
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(ex)
            ]
        };

        return session;
    }

    private static Session GetSession2_4(Stats stats)
    {
        var ex1A = new Accessory(stats, SupermanSwim)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };
        
        var ex1B = new Accessory(stats, CoreRotation)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };
        
        var ex1 = new Deadlift(stats, ExerciseType.Deadlift)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.High, Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new Deadlift(stats, AsymmetryDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 4 }
            ]
        };

        var ex3A = new Accessory(stats, ChinUp)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6 }
            ]
        };

        var ex3B = new Accessory(stats, LateralPull)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
            ]
        };

        var ex4 = new Accessory(stats, BicepsCurlReverseGrip)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 20 }
            ]
        };

        var ex5 = new Accessory(stats, WristRoll)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 1, Sets = 2 }
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
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B),
                new Round(ex1),
                new Round(ex2),
                new Round(4, ex3A, ex3B),
                new Round(ex4),
                new Round(ex5),
                new Round(2, ex6A, ex6B)
            ]
        };

        return session;
    }

    private static Session GetSession3_1(Stats stats)
    {
        var ex1A = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };
        
        var ex1B = new Accessory(stats, Superman)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };
        
        var ex1C = new Accessory(stats, Abs)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };
        
        var ex1D = new Accessory(stats, LuRaises)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };
        
        var ex1 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.High, Repeats = 10, Sets = 3 }
            ]
        };

        var ex2 = new Accessory(stats, BackLunges)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, CalfRise)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 30, Sets = 2 }
            ]
        };

        var ex4 = new Accessory(stats, SittingPress)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(stats, PressWithRubberBand)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 3 }
            ]
        };

        var ex6 = new Accessory(stats, Halo)
        {
            Repeats =
            [
                new MultiRepeat { Repeats = [10, 10], Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B, ex1C, ex1D),
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
        var ex1A = new Accessory(stats, ReversePushUp)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, SeatedBenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex2 = new Accessory(stats, BenchPress)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.High, Repeats = 6, Sets = 4 }
            ]
        };

        var ex3 = new Accessory(stats, InclineBenchPressWideGrip)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, AsymmetryBenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(stats, FrenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 20, Sets = 3 }
            ]
        };

        var ex6A = new Accessory(stats, Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            ]
        };

        var ex6B = new Accessory(stats, ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5),
                new Round(3, ex6A, ex6B)
            ]
        };

        return session;
    }

    private static Session GetSession3_3(Stats stats)
    {
        var ex1 = new MultiSnatch(stats, ExerciseType.Snatch, OverheadSquat)
        {
            Repeats = GetRange(0.5, 0.6, [3, 3], 5)
        };

        var ex2 = new MultiCleanAndJerk(stats, FrontSquat, Jerk)
        {
            Repeats = GetRange(0.5, 0.6, [1, 4], 5)
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(ex1),
                new Round(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession3_4(Stats stats)
    {
        var ex1 = new Snatch(stats.DeficitMediumGripPull, DeficitMediumGripPull)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            ]
        };

        var ex2 = new Deadlift(stats.RomanianDeadlift, RomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            ]
        };

        var ex3A = new Accessory(stats, PullUp)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 8 }
            ]
        };

        var ex3B = new Accessory(stats, LateralPullReverseGrip)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15 }
            ]
        };

        var ex4A = new Accessory(stats, BicepsCurl)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15 }
            ]
        };

        var ex4B = new Accessory(stats, DiscHammerCurls)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex5 = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 30, Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(ex1),
                new Round(ex2),
                new Round(3, ex3A, ex3B),
                new Round(3, ex4A, ex4B),
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession4_1(Stats stats)
    {
        var ex1 = new CleanAndJerk(stats.FrontSquat, FrontSquat)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.High, Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new BackSquat(stats.BenchBackSquat, BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.High, Repeats = 12, Sets = 2 }
            ]
        };

        var ex3 = new Accessory(stats, SingleLegReach)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 4 }
            ]
        };

        var ex4 = new Accessory(stats, SquatReach)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var ex5 = new CleanAndJerk(stats.PushPress, PushPress)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 8, Sets = 3 }
            ]
        };

        var ex6A = new Accessory(stats, AsymmetryPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
            ]
        };

        var ex6B = new Accessory(stats, DiscPress)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex7A = new Accessory(stats, DiscFrontRise)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 16 }
            ]
        };

        var ex7B = new Accessory(stats, DiscRussianTwist)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 16 }
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
                new Round(4, ex6A, ex6B),
                new Round(2, ex7A, ex7B)
            ]
        };

        return session;
    }

    private static Session GetSession4_2(Stats stats)
    {
        var ex1A = new Accessory(stats, ReversePushUp)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, SittingPress)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex2 = new Accessory(stats, InclineBenchPressWideGrip)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, InclineBenchPressNarrowGrip)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            ]
        };

        var ex4A = new Accessory(stats, DeclineBenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 20 }
            ]
        };

        var ex4B = new Accessory(stats, DiscBridgePullover)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex5 = new Accessory(stats, DumbbellFrenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 20, Sets = 4 }
            ]
        };

        var ex6 = new Accessory(stats, MilitaryPlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(45), Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(2, ex4A, ex4B),
                new Round(ex5),
                new Round(ex6)
            ]
        };

        return session;
    }

    private static Session GetSession4_3(Stats stats)
    {
        var ex1 = new MultiCleanAndJerk(stats, CleanPullTillPowerPosition, MuscleSquatClean)
        {
            Repeats = GetRange(0.5, 0.6, [3, 3], 5)
        };

        var ex2 = new CleanAndJerk(stats, Clean)
        {
            Repeats = GetRange(0.5, 0.6, 3, 6)
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(ex1),
                new Round(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession4_4(Stats stats)
    {
        var ex1 = new Deadlift(stats, ExerciseType.Deadlift)
        {
            IsWarmupNeeded = true,
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.High, Repeats = 10, Sets = 3 }
            ]
        };

        var ex2 = new Deadlift(stats, AsymmetryDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12, Sets = 4 }
            ]
        };

        var ex3 = new Accessory(stats, LateralPull)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 4 }
            ]
        };

        var ex4A = new Accessory(stats, BicepsCurl)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15 }
            ]
        };

        var ex4B = new Accessory(stats, WristFlexion)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex5 = new Accessory(stats, DiscJuggling)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 40, Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(3, ex4A, ex4B),
                new Round(ex5)
            ]
        };

        return session;
    }
}