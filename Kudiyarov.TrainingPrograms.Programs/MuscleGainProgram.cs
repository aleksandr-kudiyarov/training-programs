﻿using Kudiyarov.TrainingPrograms.Entities;
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

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        return new[]
        {
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4,
            GetSession4_1, GetSession4_2
        };
    }

    private static Session GetSession1_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(MuscleSquatSnatch, SnatchPushPress)
        {
            Repeats = GetRange(0.4, 0.5, Array(4, 4), 5)
        };

        var ex3 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 5), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 4), Sets = 1 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 4), Sets = 4 }
            }
        };

        var ex4 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 8, Sets = 5 }
            }
        };

        var ex5A = new Accessory(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
            }
        };

        var ex5B = new Accessory(FrenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15 }
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
                new(3, ex5A, ex5B)
            }
        };

        return session;
    }

    private static Session GetSession1_2()
    {
        var ex1 = new CleanAndJerk(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 12, Sets = 4 }
            }
        };

        var ex2 = new MultiCleanAndJerk(PowerClean, PushPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 6), Sets = 4 }
            }
        };

        var ex3 = new Accessory(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Intensity = Intensity.Medium, Repeats = Array(8, 8), Sets = 4 }
            }
        };

        var ex4 = new Accessory(BoxJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8, Sets = 3 }
            }
        };

        var ex5 = new Accessory(Plank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(50) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(40) }
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
                new(ex5)
            }
        };

        return session;
    }
    
    private static Session GetSession1_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(MuscleSnatch, SotsPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(4, 4), Sets = 3 }
            }
        };

        var ex3 = new Snatch(PowerSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 4 }
            }
        };

        var ex4 = new Snatch(DeficitRomanianDeadlift)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.6, Repeats = 10, Sets = 5 }
            }
        };

        var ex5 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6 },
                new SingleRepeat { Percent = 0.6, Repeats = 6 },
                new SingleRepeat { Percent = 0.7, Repeats = 6 }
            }
        };

        var ex6A = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.8, Repeats = 6 }
            }
        };
        
        var ex6B = new Accessory(GakkSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
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
                new(3, ex6A, ex6B)
            }
        };

        return session;
    }
    
    private static Session GetSession1_4()
    {
        var ex1 = new CleanAndJerk(Thruster)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 10, Sets = 3 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 2), Sets = 3 }
            }
        };

        var ex3 = new MultiCleanAndJerk(CleanPull, HangCleanPullBelowKnee)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 5), Sets = 1 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 5), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 4), Sets = 4 }
            }
        };

        var ex4 = new BackSquat(BenchBackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 6, Sets = 4 }
            }
        };

        var ex5A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex5B = new Accessory(Press)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10 }
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
                new(3, ex5A, ex5B)
            }
        };

        return session;
    }
    
    private static Session GetSession2_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(ExerciseType.Snatch, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 4), Sets = 2 }, 
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 4), Sets = 4 } 
            }
        };

        var ex3 = new Snatch(SnatchPullFromBlocks)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.65, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 6, Sets = 4 }
            }
        };

        var ex4 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 4 }
            }
        };

        var ex5A = new Accessory(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
            }
        };

        var ex5B = new Accessory(FrenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15 }
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
                new(4, ex5A, ex5B)
            }
        };

        return session;
    }

    private static Session GetSession2_2()
    {
        var ex1 = new MultiCleanAndJerk(FrontSquat, PushPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(4, 4), Sets = 4 }
            }
        };

        var ex2 = new CleanAndJerk(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 12, Sets = 4 }
            }
        };

        var ex3 = new Accessory(BackLunges)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Intensity = Intensity.Medium, Repeats = Array(6, 6), Sets = 3 }
            }
        };

        var ex4 = new Accessory(BoxJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 4 }
            }
        };

        var ex5 = new Accessory(Plank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60), Sets = 4 }
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
                new(ex5)
            }
        };

        return session;
    }
    
    private static Session GetSession2_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20, Sets = 2 }
            }
        };

        var ex2 = new MultiSnatch(MuscleSnatch, SotsPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = Constants.Bar, Repeats = Array(6, 6), Sets = 3 }
            }
        };

        var ex3 = new MultiSnatch(SnatchPull, PowerSnatch)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 4 }
            }
        };

        var ex4 = new Snatch(RomanianDeadlift)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.65, Repeats = 12, Sets = 4 }
            }
        };

        var ex5 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 10 },
                new SingleRepeat { Percent = 0.6, Repeats = 8 }
            }
        };

        var ex6A = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.75, Repeats = 6 }
            }
        };
        
        var ex6B = new Accessory(GakkSquat)
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
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5),
                new(3, ex6A, ex6B)
            }
        };

        return session;
    }
    
    private static Session GetSession2_4()
    {
        var ex1 = new CleanAndJerk(Thruster)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 12, Sets = 3 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(ExerciseType.Deadlift)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.75, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 6, Sets = 4 }
            }
        };

        var ex4 = new BackSquat(BenchBackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 5, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 5, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 5, Sets = 2 },
                new SingleRepeat { Percent = 0.50, Repeats = 10, Sets = 2 }
            }
        };

        var ex5A = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15 }
            }
        };

        var ex5B = new Accessory(Press)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10 }
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
                new(4, ex5A, ex5B)
            }
        };

        return session;
    }
    
    private static Session GetSession3_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 3 }
            }
        };

        var ex2 = new Snatch(DeficitSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 3 }
            }
        };

        var ex3 = new Snatch(DeficitSnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 3 }
            }
        };

        var ex4 = new BackSquat(BackSquatNarrowFeet)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 6, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }
    
    private static Session GetSession3_2()
    {
        var ex1 = new MultiCleanAndJerk(MuscleSquatClean, FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(4, 4), Sets = 3 }
            }
        };

        var ex2 = new CleanAndJerk(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 8, Sets = 3 }
            }
        };

        var ex3 = new Accessory(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Intensity = Intensity.Medium, Repeats = Array(6, 6), Sets = 3 }
            }
        };

        var ex4 = new Accessory(Plank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = TimeSpan.FromSeconds(40) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(35) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(30) }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession3_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(HipSnatch, PushPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 4), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(1, 3), Sets = 3 }
            }
        };

        var ex3 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 5), Sets = 2 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 3), Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession3_4()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20, Sets = 2 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(CleanPullSlowlyDown)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 1, Sets = 1 }
            }
        };

        var ex4 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
            }
        };

        var ex5 = new Accessory(Press)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Medium, Repeats = 10, Sets = 4 }
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
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession4_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(ExerciseType.Snatch, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 2 }
            }
        };

        var ex3 = new Snatch(MediumGripPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 10, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 6, Sets = 3 }
            }
        };

        var ex4 = new BackSquat(BackSquatPause)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 3 }
            }
        };
        
        var ex5A = new Accessory(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 12 }
            }
        };

        var ex5B = new Accessory(FrenchPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 15 }
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
                new(4, ex5A, ex5B)
            }
        };

        return session;
    }

    private static Session GetSession4_2()
    {
        var ex1 = new MultiCleanAndJerk(PowerClean, PushPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 6), Sets = 3 }
            }
        };

        var ex2 = new Snatch(SnatchPushPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 10, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 8, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 6, Sets = 3 }
            }
        };
        
        var ex3 = new CleanAndJerk(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 12, Sets = 4 }
            }
        };
        
        var ex4 = new Accessory(BoxJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8, Sets = 4 }
            }
        };

        var ex5 = new Accessory(Plank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(50) },
                new StaticRepeat { Duration = TimeSpan.FromSeconds(40) }
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
                new(ex5)
            }
        };

        return session;
    }
}