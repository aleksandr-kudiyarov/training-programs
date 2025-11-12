using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs;

public sealed class MuscleGainProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.MuscleGain;
    public override string Name => "Muscle Gain";

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
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, MuscleSquatSnatch, SnatchPushPress)
        {
            Repeats = GetRange(0.4, 0.5, Array(4, 4), 5)
        };

        var ex3 = new MultiSnatch(stats, SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 5), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 4), Sets = 1 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 4), Sets = 4 }
            ]
        };

        var ex4 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 8, Sets = 5 }
            ]
        };

        var ex5A = new Accessory(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
            ]
        };

        var ex5B = new Accessory(stats, FrenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15 }
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
                new Round(3, ex5A, ex5B)
            ]
        };

        return session;
    }

    private static Session GetSession1_2(Stats stats)
    {
        var ex1 = new CleanAndJerk(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 12, Sets = 4 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, PowerClean, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 6), Sets = 4 }
            ]
        };

        var ex3 = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Intensity = Intensity.Medium, Repeats = Array(8, 8), Sets = 4 }
            ]
        };

        var ex4 = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(stats, Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(50) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(40) }
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
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, MuscleSnatch, SotsPress)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(4, 4), Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, PowerSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 4 }
            ]
        };

        var ex4 = new Snatch(stats, DeficitRomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 10, Sets = 5 }
            ]
        };

        var ex5 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6 },
                new SingleRepeat { Percent = 0.6, Repeats = 6 },
                new SingleRepeat { Percent = 0.7, Repeats = 6 }
            ]
        };

        var ex6A = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 6 }
            ]
        };
        
        var ex6B = new Accessory(stats, GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
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
                new Round(3, ex6A, ex6B)
            ]
        };

        return session;
    }
    
    private static Session GetSession1_4(Stats stats)
    {
        var ex1 = new CleanAndJerk(stats, Thruster)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 10, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 3 }
            ]
        };

        var ex3 = new MultiCleanAndJerk(stats, CleanPull, HangCleanPullBelowKnee)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 5), Sets = 1 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 5), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 4), Sets = 4 }
            ]
        };

        var ex4 = new BackSquat(stats, BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 6, Sets = 4 }
            ]
        };

        var ex5A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex5B = new Accessory(stats, Press)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10 }
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
                new Round(3, ex5A, ex5B)
            ]
        };

        return session;
    }
    
    private static Session GetSession2_1(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, ExerciseType.Snatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 4), Sets = 2 }, 
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 4), Sets = 4 }
            ]
        };

        var ex3 = new Snatch(stats, SnatchPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.65, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 6, Sets = 4 }
            ]
        };

        var ex4 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 4 }
            ]
        };

        var ex5A = new Accessory(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
            ]
        };

        var ex5B = new Accessory(stats, FrenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15 }
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
                new Round(4, ex5A, ex5B)
            ]
        };

        return session;
    }

    private static Session GetSession2_2(Stats stats)
    {
        var ex1 = new MultiCleanAndJerk(stats, FrontSquat, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(4, 4), Sets = 4 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 12, Sets = 4 }
            ]
        };

        var ex3 = new Accessory(stats, BackLunges)
        {
            Repeats =
            [
                new MultiRepeat { Intensity = Intensity.Medium, Repeats = Array(6, 6), Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(stats, Plank)
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
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5)
            ]
        };

        return session;
    }
    
    private static Session GetSession2_3(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var ex2 = new MultiSnatch(stats, MuscleSnatch, SotsPress)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(6, 6), Sets = 3 }
            ]
        };

        var ex3 = new MultiSnatch(stats, SnatchPull, PowerSnatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 4 }
            ]
        };

        var ex4 = new Snatch(stats, RomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.65, Repeats = 12, Sets = 4 }
            ]
        };

        var ex5 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 10 },
                new SingleRepeat { Percent = 0.6, Repeats = 8 }
            ]
        };

        var ex6A = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.75, Repeats = 6 }
            ]
        };
        
        var ex6B = new Accessory(stats, GakkSquat)
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
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5),
                new Round(3, ex6A, ex6B)
            ]
        };

        return session;
    }
    
    private static Session GetSession2_4(Stats stats)
    {
        var ex1 = new CleanAndJerk(stats, Thruster)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 12, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.75, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 6, Sets = 4 }
            ]
        };

        var ex4 = new BackSquat(stats, BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 5, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 5, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 5, Sets = 2 },
                new SingleRepeat { Percent = 0.50, Repeats = 10, Sets = 2 }
            ]
        };

        var ex5A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex5B = new Accessory(stats, Press)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10 }
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
                new Round(4, ex5A, ex5B)
            ]
        };

        return session;
    }
    
    private static Session GetSession3_1(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 3 }
            ]
        };

        var ex2 = new Snatch(stats, DeficitSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, DeficitSnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 3 }
            ]
        };

        var ex4 = new BackSquat(stats, BackSquatNarrowFeet)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 6, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }
    
    private static Session GetSession3_2(Stats stats)
    {
        var ex1 = new MultiCleanAndJerk(stats, MuscleSquatClean, FrontSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(4, 4), Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 8, Sets = 3 }
            ]
        };

        var ex3 = new Accessory(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Intensity = Intensity.Medium, Repeats = Array(6, 6), Sets = 3 }
            ]
        };

        var ex4 = new Accessory(stats, Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(40) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(35) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(ex1),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession3_3(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, HipSnatch, SnatchPushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 4), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 3), Sets = 3 }
            ]
        };

        var ex3 = new MultiSnatch(stats, SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 5), Sets = 2 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 3), Sets = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
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
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, CleanPullSlowlyDown)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 1, Sets = 1 }
            ]
        };

        var ex4 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(stats, Press)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10, Sets = 4 }
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

    private static Session GetSession4_1(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(stats, ExerciseType.Snatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 2 }
            ]
        };

        var ex3 = new Snatch(stats, MediumGripPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 10, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 6, Sets = 3 }
            ]
        };

        var ex4 = new BackSquat(stats, BackSquatPause)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 3 }
            ]
        };
        
        var ex5A = new Accessory(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
            ]
        };

        var ex5B = new Accessory(stats, FrenchPress)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15 }
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
                new Round(4, ex5A, ex5B)
            ]
        };

        return session;
    }

    private static Session GetSession4_2(Stats stats)
    {
        var ex1 = new MultiCleanAndJerk(stats, PowerClean, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 6), Sets = 3 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchPushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 10, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 6, Sets = 3 }
            ]
        };
        
        var ex3 = new CleanAndJerk(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 12, Sets = 4 }
            ]
        };
        
        var ex4 = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(stats, Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(50) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(40) }
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

    private static Session GetSession4_3(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var ex2 = new MultiSnatch(stats, MuscleSnatch, SotsPress)
        {
            Repeats =
            [
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(6, 6), Sets = 3 }
            ]
        };

        var ex3 = new MultiSnatch(stats, SnatchPullTillPower, PowerSnatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 1), Sets = 3 }
            ]
        };

        var ex4 = new Snatch(stats, DeficitRomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 12, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 10, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 8, Sets = 3 }
            ]
        };

        var ex5 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 10, Sets = 1 },
                new SingleRepeat { Percent = 0.60, Repeats = 10, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 10, Sets = 3 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 1 }
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
    
    private static Session GetSession4_4(Stats stats)
    {
        var ex1 = new CleanAndJerk(stats, Thruster)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.35, Repeats = 12, Sets = 4 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, CleanPull, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(3, 1, 1), Sets = 1 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, CleanPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 8, Sets = 3 },
                new SingleRepeat { Percent = 1.0, Repeats = 4, Sets = 1 }
            ]
        };

        var ex4 = new BackSquat(stats, BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 10, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 2 },
                new SingleRepeat { Percent = 0.5, Repeats = 12, Sets = 2 }
            ]
        };

        var ex5A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex5B = new Accessory(stats, Press)
        {
            Repeats =
            [
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 12 }
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
                new Round(3, ex5A, ex5B)
            ]
        };

        return session;
    }
}