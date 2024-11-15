using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Strength;

public sealed class DeadliftProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.Deadlift;
    public override string Name => "Deadlift Program";

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        return
        [
            GetSession1_1, GetSession1_2, GetSession1_3,
            GetSession2_1, GetSession2_2, GetSession2_3,
            GetSession3_1, GetSession3_2, GetSession3_3,
            GetSession4_1, GetSession4_2, GetSession4_3,
            GetSession5_1, GetSession5_2, GetSession5_3,
            GetSession6_1, GetSession6_2, GetSession6_3,
            GetSession7_1, GetSession7_2, GetSession7_3,
            GetSession8_1, GetSession8_2, GetSession8_3,
            GetSession9_1, GetSession9_2, GetSession9_3,
            GetSession10_1, GetSession10_2, GetSession10_3,
            GetSession11_1, GetSession11_2, GetSession11_3,
            GetSession12_1, EmptySession, GetSession12_3,
            GetRpSession
        ];
    }

    private static Session GetSession1_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new MultiSnatch(PowerSnatch, SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2, 1], Sets = 4 }
            ]
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5 },
                new SingleRepeat { Percent = 0.6, Repeats = 5 },
                new SingleRepeat { Percent = 0.7, Repeats = 5 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
            ]
        };

        var ex4 = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(Plank)
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
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession1_2()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 4 }
            ]
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 3 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 1], Sets = 3 }
            ]
        };

        var ex5 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4 },
                new SingleRepeat { Percent = 0.6, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession1_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new CleanAndJerk(DeficitClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 4 }
            ]
        };

        var ex3 = new Deadlift(DeficitDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5 },
                new SingleRepeat { Percent = 0.6, Repeats = 5 },
                new SingleRepeat { Percent = 0.7, Repeats = 5, Sets = 5 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(FrontSquat, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [1, 3], Sets = 4 }
            ]
        };

        var ex5 = new Accessory(ReversePlank)
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
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession2_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(PowerClean, PowerCleanBelowKnee, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [1, 2, 3], Sets = 4 }
            ]
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 5 },
                new SingleRepeat { Percent = 0.600, Repeats = 5 },
                new SingleRepeat { Percent = 0.700, Repeats = 5 },
                new SingleRepeat { Percent = 0.825, Repeats = 4, Sets = 4 }
            ]
        };

        var ex4 = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(Plank)
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
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession2_2()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 4 }
            ]
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [1, 3], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 3], Sets = 3 }
            ]
        };

        var ex5 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5 },
                new SingleRepeat { Percent = 0.6, Repeats = 5 },
                new SingleRepeat { Percent = 0.7, Repeats = 5 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession2_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new MultiSnatch(DeficitPowerSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 4 }
            ]
        };

        var ex3 = new Deadlift(DeficitDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 5 },
                new SingleRepeat { Percent = 0.600, Repeats = 5 },
                new SingleRepeat { Percent = 0.775, Repeats = 5, Sets = 4 }
            ]
        };

        var ex4 = new Snatch(SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 6, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(ReversePlank)
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
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession3_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new Snatch(MuscleSquatSnatch)
        {
            Repeats = GetRange(0.4, 0.5, 4, 4)
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 5 },
                new SingleRepeat { Percent = 0.60, Repeats = 5 },
                new SingleRepeat { Percent = 0.70, Repeats = 5 },
                new SingleRepeat { Percent = 0.80, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60), Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession3_2()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 4 }
            ]
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 1], Sets = 3 },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 1] }
            ]
        };

        var ex5 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 5 },
                new SingleRepeat { Percent = 0.60, Repeats = 5 },
                new SingleRepeat { Percent = 0.70, Repeats = 5 },
                new SingleRepeat { Percent = 0.80, Repeats = 5 },
                new SingleRepeat { Percent = 0.85, Repeats = 5, Sets = 5 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession3_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new CleanAndJerk(GoodMorningSquat)
        {
            Repeats = GetRange(0.4, 0.5, 6, 3)
        };

        var ex3 = new Deadlift(DeficitDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 5 },
                new SingleRepeat { Percent = 0.600, Repeats = 5 },
                new SingleRepeat { Percent = 0.700, Repeats = 5 },
                new SingleRepeat { Percent = 0.825, Repeats = 4, Sets = 4 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(FrontSquat, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [1, 5], Sets = 4 }
            ]
        };

        var ex5 = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60), Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession4_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(Clean, HangCleanBelowKnee)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [1, 3], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 1], Sets = 3 }
            ]
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 4 },
                new SingleRepeat { Percent = 0.600, Repeats = 4 },
                new SingleRepeat { Percent = 0.700, Repeats = 4 },
                new SingleRepeat { Percent = 0.825, Repeats = 3, Sets = 4 }
            ]
        };

        var ex4 = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60), Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession4_2()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 5 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 2], Sets = 3 }
            ]
        };

        var ex5 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession4_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new MultiSnatch(DeficitPowerSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [3, 1], Sets = 4 }
            ]
        };

        var ex3 = new Deadlift(DeficitDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3 },
                new SingleRepeat { Percent = 0.600, Repeats = 3 },
                new SingleRepeat { Percent = 0.700, Repeats = 3 },
                new SingleRepeat { Percent = 0.800, Repeats = 3 },
                new SingleRepeat { Percent = 0.825, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new Snatch(SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60), Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession5_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new MultiSnatch(PowerSnatch, SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2, 2], Sets = 4 }
            ]
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3 },
                new SingleRepeat { Percent = 0.600, Repeats = 3 },
                new SingleRepeat { Percent = 0.700, Repeats = 3 },
                new SingleRepeat { Percent = 0.800, Repeats = 3 },
                new SingleRepeat { Percent = 0.900, Repeats = 2 },
                new SingleRepeat { Percent = 0.925, Repeats = 2 },
                new SingleRepeat { Percent = 0.950, Repeats = 2 }
            ]
        };

        var ex4 = new Accessory(BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90), Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession5_2()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 4 }
            ]
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 1, Sets = 4 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 1], Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 1] },
                new MultiRepeat { Percent = 0.8, Repeats = [1, 1] }
            ]
        };

        var ex5 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3 },
                new SingleRepeat { Percent = 0.65, Repeats = 3 },
                new SingleRepeat { Percent = 0.75, Repeats = 3 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession5_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 4 }
            ]
        };

        var ex2 = new CleanAndJerk(DeficitClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new Deadlift(DeficitDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3 },
                new SingleRepeat { Percent = 0.60, Repeats = 3 },
                new SingleRepeat { Percent = 0.70, Repeats = 3 },
                new SingleRepeat { Percent = 0.80, Repeats = 3 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(PushPress, PowerJerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 3], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 3], Sets = 3 }
            ]
        };

        var ex5 = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90), Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession6_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(Clean, HangCleanBelowKnee)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [1, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 1], Sets = 2 }
            ]
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3 },
                new SingleRepeat { Percent = 0.60, Repeats = 3 },
                new SingleRepeat { Percent = 0.70, Repeats = 3 },
                new SingleRepeat { Percent = 0.80, Repeats = 3 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90), Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession6_2()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12, Sets = 3 }
            ]
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat
                {
                    Percent = 0.4, Repeats = 3, Sets = 5
                }
            ]
        };

        var ex4 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = [3, 3], Sets = 5 }
            ]
        };

        var ex5 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession6_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(DeficitPowerSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 1], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 1], Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 1], Sets = 2 }
            ]
        };

        var ex3 = new Deadlift(DeficitDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new Snatch(SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90), Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession7_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(PowerSnatch, HipSnatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [1, 3], Sets = 4 }
            ]
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3 },
                new SingleRepeat { Percent = 0.60, Repeats = 3 },
                new SingleRepeat { Percent = 0.70, Repeats = 3 },
                new SingleRepeat { Percent = 0.80, Repeats = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 2 },
                new SingleRepeat { Percent = 0.95, Repeats = 1, Sets = 2 }
            ]
        };

        var ex4 = new Accessory(BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 4 }
            ]
        };

        var ex5A = new Accessory(Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var ex5B = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(2, ex5A, ex5B)
            ]
        };

        return session;
    }

    private static Session GetSession7_2()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 3], Sets = 3 }
            ]
        };

        var ex5 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession7_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(CleanFromBlocks, FrontSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [3, 1], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 1], Sets = 3 }
            ]
        };

        var ex3 = new Deadlift(DeadliftFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(PushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 3 }
            ]
        };

        var ex5A = new Accessory(Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var ex5B = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(2, ex5A, ex5B)
            ]
        };

        return session;
    }

    private static Session GetSession8_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(PowerClean, PowerCleanBelowKnee)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [1, 3], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 2], Sets = 2 }
            ]
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 4 },
                new SingleRepeat { Percent = 0.60, Repeats = 4 },
                new SingleRepeat { Percent = 0.70, Repeats = 4 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.95, Repeats = 3 }
            ]
        };

        var ex4 = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 4 }
            ]
        };

        var ex5A = new Accessory(Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var ex5B = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(2, ex5A, ex5B)
            ]
        };

        return session;
    }

    private static Session GetSession8_2()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10, Sets = 3 }
            ]
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 1, Sets = 2 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 3 }
            ]
        };

        var ex5 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 5 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession8_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new Snatch(SnatchFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3 },
                new SingleRepeat { Percent = 0.60, Repeats = 3 },
                new SingleRepeat { Percent = 0.70, Repeats = 3 },
                new SingleRepeat { Percent = 0.80, Repeats = 3 },
                new SingleRepeat { Percent = 0.90, Repeats = 3 },
                new SingleRepeat { Percent = 0.95, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 6, Sets = 4 }
            ]
        };

        var ex5A = new Accessory(Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var ex5B = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(2, ex5A, ex5B)
            ]
        };

        return session;
    }

    private static Session GetSession9_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new Snatch(MuscleSquatSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 4, Sets = 3 }
            ]
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 4 }
            ]
        };

        var ex5A = new Accessory(Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var ex5B = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(2, ex5A, ex5B)
            ]
        };

        return session;
    }

    private static Session GetSession9_2()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 1], Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 1], Sets = 2 },
                new MultiRepeat { Percent = 0.8, Repeats = [1, 1] }
            ]
        };

        var ex5 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession9_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(CleanFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 3 }
            ]
        };

        var ex3 = new Deadlift(DeadliftFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 3 },
                new SingleRepeat { Percent = 1, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new MultiCleanAndJerk(PushPress, PowerJerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 3], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 2], Sets = 3 }
            ]
        };

        var ex5A = new Accessory(Plank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var ex5B = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90) }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(2, ex5A, ex5B)
            ]
        };

        return session;
    }

    private static Session GetSession10_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(PowerClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 1, Sets = 2 }
            ]
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 4 },
                new SingleRepeat { Percent = 0.700, Repeats = 4 },
                new SingleRepeat { Percent = 0.750, Repeats = 3 },
                new SingleRepeat { Percent = 0.825, Repeats = 3, Sets = 3 }
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
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90), Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession10_2()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 4 }
            ]
        };

        var ex3 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = [3, 3], Sets = 3 }
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

    private static Session GetSession10_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 3 }
            ]
        };

        var ex2 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 1], Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 2 },
                new SingleRepeat { Percent = 0.95, Repeats = 2 }
            ]
        };

        var ex4 = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 8, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(90), Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession11_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var ex2 = new Snatch(PowerSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3 },
                new SingleRepeat { Percent = 0.60, Repeats = 3 },
                new SingleRepeat { Percent = 0.70, Repeats = 3 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 3 }
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
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60), Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession11_2()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var ex2 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = [2, 2], Sets = 3 }
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

    private static Session GetSession11_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20, Sets = 2 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(Clean, FrontSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 1], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 1], Sets = 2 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3 },
                new SingleRepeat { Percent = 0.60, Repeats = 3 },
                new SingleRepeat { Percent = 0.70, Repeats = 3 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new Accessory(ReversePlank)
        {
            Repeats =
            [
                new StaticRepeat { Duration = TimeSpan.FromSeconds(60), Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession12_1()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 4, Sets = 5 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession12_3()
    {
        var ex1 = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex2 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1),
                new(ex2)
            ]
        };

        return session;
    }

    private static Session GetRpSession()
    {
        var ex1 = new Deadlift(ExerciseType.Deadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.40, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.95, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.05, Repeats = 1, Sets = 1 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(ex1)
            ]
        };

        return session;
    }
}