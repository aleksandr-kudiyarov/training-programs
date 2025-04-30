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

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        return new Func<Session>[]
        {
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4
        };
    }

    private static Session GetSession1_1()
    {
        var ex1A = new Accessory(GakkSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };
        
        var ex1B = new Accessory(Superman)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };
        
        var ex1C = new Accessory(Abs)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };
        
        var ex1D = new Accessory(LuRaises)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };
        
        var ex2 = new BackSquat(ExerciseType.BackSquat)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 8, Sets = 3 }
            }
        };

        var ex3 = new BackSquat(Stats.BenchBackSquat, BenchBackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10, Sets = 3 }
            }
        };

        var ex4 = new Accessory(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Intensity = Intensity.Light, Repeats = new[] { 15, 15 }, Sets = 2 }
            }
        };

        var ex5 = new Accessory(CalfRise)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20, Sets = 2 }
            }
        };

        var ex6 = new CleanAndJerk(Stats.PushPress, PushPress)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 8, Sets = 3 }
            }
        };

        var ex7 = new Accessory(Press)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            }
        };

        var ex8 = new Accessory(ReverseFly)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20, Sets = 2 }
            }
        };

        var ex9 = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 2 }
            }
        };

        var ex10 = new Accessory(Plank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = TimeSpan.FromSeconds(45), Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, ex1A, ex1B, ex1C, ex1D),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5),
                new(ex6),
                new(ex7),
                new(ex8),
                new(ex9),
                new(ex10)
            }
        };

        return session;
    }

    private static Session GetSession1_2()
    {
        var ex1A = new Accessory(PushUp)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var ex1B = new Accessory(ReversePushUp)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var ex2 = new Accessory(BenchPress)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10, Sets = 3 }
            }
        };

        var ex3 = new Accessory(InclineBenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 3 }
            }
        };

        var ex4 = new Accessory(SeatedBenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 25, Sets = 2 }
            }
        };

        var ex5 = new Accessory(FrenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            }
        };

        var ex6A = new Accessory(TricepsExtension)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Repeats = new[] { 20, 20 } }
            }
        };

        var ex6B = new Accessory(MilitaryPlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5),
                new(2, ex6A, ex6B)
            }
        };

        return session;
    }

    private static Session GetSession1_3()
    {
        var ex = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
        {
            Repeats = GetRange(0.5, 0.6, new[] { 2, 2 }, 6)
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex)
            }
        };

        return session;
    }

    private static Session GetSession1_4()
    {
        var ex1 = new Deadlift(Stats.SnatchDeadlift, SnatchDeadlift)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 8, Sets = 3 }
            }
        };

        var ex2 = new Deadlift(Stats.RomanianDeadlift, RomanianDeadlift)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            }
        };

        var ex3 = new Accessory(LateralPull)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            }
        };

        var ex4 = new Accessory(BicepsCurl)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            }
        };

        var ex5 = new Accessory(WristFlexion)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 2 }
            }
        };

        var ex6 = new Accessory(DiscJuggling)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 30, Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5),
                new(ex6)
            }
        };

        return session;
    }

    private static Session GetSession2_1()
    {
        var ex1A = new Accessory(SupermanCrossed)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };
        
        var ex1B = new Accessory(GluteBridge)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };
        
        var ex1C = new Accessory(Abs)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };
        
        var ex1D = new Accessory(LuRaises)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };
        
        var ex1 = new CleanAndJerk(FrontSquat)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.High, Repeats = 6, Sets = 3 }
            }
        };

        var ex2 = new BackSquat(Stats.BenchBackSquat, BenchBackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            }
        };

        var ex3 = new Accessory(ForwardLunges)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Intensity = Intensity.Light, Repeats = new[] { 12, 12 }, Sets = 3 }
            }
        };

        var ex4 = new Snatch(SnatchPushPress)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10, Sets = 3 }
            }
        };
        
        var ex5 = new Accessory(AsymmetryPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 4 }
            }
        };

        var ex6A = new Accessory(LateralRaise)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex6B = new Accessory(DiscPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex7 = new Accessory(ReversePlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = TimeSpan.FromSeconds(45), Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B, ex1C, ex1D),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5),
                new(2, ex6A, ex6B),
                new(ex7)
            }
        };

        return session;
    }

    private static Session GetSession2_2()
    {
        var ex1A = new Accessory(WidePushUp)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10 }
            }
        };

        var ex1B = new Accessory(SeatedBenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex2 = new Accessory(BenchPress)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.High, Repeats = 10, Sets = 3 }
            }
        };

        var ex3 = new Accessory(AsymmetryBenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 4 }
            }
        };

        var ex4 = new Accessory(InclineBenchPressNarrowGrip)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            }
        };

        var ex5 = new Accessory(FrenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 20, Sets = 4 }
            }
        };

        var ex6A = new Accessory(TricepsExtension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 30 }
            }
        };

        var ex6B = new Accessory(ReversePushUp)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5),
                new(2, ex6A, ex6B)
            }
        };

        return session;
    }

    private static Session GetSession2_3()
    {
        var ex = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = GetRange(0.5, 0.6, new[] { 2, 2 }, 6)
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex)
            }
        };

        return session;
    }

    private static Session GetSession2_4()
    {
        var ex1A = new Accessory(SupermanSwim)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };
        
        var ex1B = new Accessory(CoreRotation)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };
        
        var ex1 = new Deadlift(ExerciseType.Deadlift)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.High, Repeats = 8, Sets = 3 }
            }
        };

        var ex2 = new Deadlift(AsymmetryDeadlift)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 4 }
            }
        };

        var ex3A = new Accessory(ChinUp)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6 }
            }
        };

        var ex3B = new Accessory(LateralPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
            }
        };

        var ex4 = new Accessory(BicepsCurlReverseGrip)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 20 }
            }
        };

        var ex5 = new Accessory(WristRoll)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 1, Sets = 2 }
            }
        };

        var ex6A = new Accessory(Plank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60) }
            }
        };

        var ex6B = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex1),
                new(ex2),
                new(4, ex3A, ex3B),
                new(ex4),
                new(ex5),
                new(2, ex6A, ex6B)
            }
        };

        return session;
    }

    private static Session GetSession3_1()
    {
        var ex1A = new Accessory(GakkSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };
        
        var ex1B = new Accessory(Superman)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };
        
        var ex1C = new Accessory(Abs)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };
        
        var ex1D = new Accessory(LuRaises)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };
        
        var ex1 = new BackSquat(ExerciseType.BackSquat)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.High, Repeats = 10, Sets = 3 }
            }
        };

        var ex2 = new Accessory(BackLunges)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            }
        };

        var ex3 = new Accessory(CalfRise)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 30, Sets = 2 }
            }
        };

        var ex4 = new Accessory(SittingPress)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            }
        };

        var ex5 = new Accessory(PressWithRubberBand)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 3 }
            }
        };

        var ex6 = new Accessory(Halo)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Repeats = new[] { 10, 10 }, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B, ex1C, ex1D),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5),
                new(ex6)
            }
        };

        return session;
    }

    private static Session GetSession3_2()
    {
        var ex1A = new Accessory(ReversePushUp)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(SeatedBenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex2 = new Accessory(BenchPress)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.High, Repeats = 6, Sets = 4 }
            }
        };

        var ex3 = new Accessory(InclineBenchPressWideGrip)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            }
        };

        var ex4 = new Accessory(AsymmetryBenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15, Sets = 4 }
            }
        };

        var ex5 = new Accessory(FrenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 20, Sets = 3 }
            }
        };

        var ex6A = new Accessory(Plank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            }
        };

        var ex6B = new Accessory(ReversePlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5),
                new(3, ex6A, ex6B)
            }
        };

        return session;
    }

    private static Session GetSession3_3()
    {
        var ex1 = new MultiSnatch(ExerciseType.Snatch, OverheadSquat)
        {
            Repeats = GetRange(0.5, 0.6, new[] { 3, 3 }, 5)
        };

        var ex2 = new MultiCleanAndJerk(FrontSquat, Jerk)
        {
            Repeats = GetRange(0.5, 0.6, new[] { 1, 4 }, 5)
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2)
            }
        };

        return session;
    }

    private static Session GetSession3_4()
    {
        var ex1 = new Snatch(Stats.DeficitMediumGripPull, DeficitMediumGripPull)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            }
        };

        var ex2 = new Deadlift(Stats.RomanianDeadlift, RomanianDeadlift)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            }
        };

        var ex3A = new Accessory(PullUp)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 8 }
            }
        };

        var ex3B = new Accessory(LateralPullReverseGrip)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15 }
            }
        };

        var ex4A = new Accessory(BicepsCurl)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15 }
            }
        };

        var ex4B = new Accessory(DiscHammerCurls)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex5 = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 30, Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2),
                new(3, ex3A, ex3B),
                new(3, ex4A, ex4B),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession4_1()
    {
        var ex1 = new CleanAndJerk(Stats.FrontSquat, FrontSquat)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.High, Repeats = 8, Sets = 3 }
            }
        };

        var ex2 = new BackSquat(Stats.BenchBackSquat, BenchBackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.High, Repeats = 12, Sets = 2 }
            }
        };

        var ex3 = new Accessory(SingleLegReach)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 4 }
            }
        };

        var ex4 = new Accessory(SquatReach)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20, Sets = 2 }
            }
        };

        var ex5 = new CleanAndJerk(Stats.PushPress, PushPress)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 8, Sets = 3 }
            }
        };

        var ex6A = new Accessory(AsymmetryPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
            }
        };

        var ex6B = new Accessory(DiscPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12 }
            }
        };

        var ex7A = new Accessory(DiscFrontRise)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 16 }
            }
        };

        var ex7B = new Accessory(DiscRussianTwist)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 16 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5),
                new(4, ex6A, ex6B),
                new(2, ex7A, ex7B)
            }
        };

        return session;
    }

    private static Session GetSession4_2()
    {
        var ex1A = new Accessory(ReversePushUp)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex1B = new Accessory(SittingPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex2 = new Accessory(InclineBenchPressWideGrip)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 3 }
            }
        };

        var ex3 = new Accessory(InclineBenchPressNarrowGrip)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15, Sets = 3 }
            }
        };

        var ex4A = new Accessory(DeclineBenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 20 }
            }
        };

        var ex4B = new Accessory(DiscBridgePullover)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex5 = new Accessory(DumbbellFrenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 20, Sets = 4 }
            }
        };

        var ex6 = new Accessory(MilitaryPlank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = TimeSpan.FromSeconds(45), Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(2, ex4A, ex4B),
                new(ex5),
                new(ex6)
            }
        };

        return session;
    }

    private static Session GetSession4_3()
    {
        var ex1 = new MultiCleanAndJerk(CleanPullTillPowerPosition, MuscleSquatClean)
        {
            Repeats = GetRange(0.5, 0.6, new[] { 3, 3 }, 5)
        };

        var ex2 = new CleanAndJerk(Clean)
        {
            Repeats = GetRange(0.5, 0.6, 3, 6)
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2)
            }
        };

        return session;
    }

    private static Session GetSession4_4()
    {
        var ex1 = new Deadlift(ExerciseType.Deadlift)
        {
            IsWarmupNeeded = true,
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.High, Repeats = 10, Sets = 3 }
            }
        };

        var ex2 = new Deadlift(AsymmetryDeadlift)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12, Sets = 4 }
            }
        };

        var ex3 = new Accessory(LateralPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12, Sets = 4 }
            }
        };

        var ex4A = new Accessory(BicepsCurl)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 15 }
            }
        };

        var ex4B = new Accessory(WristFlexion)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20 }
            }
        };

        var ex5 = new Accessory(DiscJuggling)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 40, Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2),
                new(ex3),
                new(3, ex4A, ex4B),
                new(ex5)
            }
        };

        return session;
    }
}