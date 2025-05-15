using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Strength;

public sealed class LegsProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.Legs;
    public override string Name => "Legs Program";

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        return
        [
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4,
            GetSession5_1, GetSession5_2, GetSession5_3, GetSession5_4
        ];
    }

    private static Session GetSession1_1()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new MultiSnatch(ExerciseType.Snatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [3, 3], Sets = 4 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 8 },
                new SingleRepeat { Percent = 0.6, Repeats = 8, Sets = 4 }
            ]
        };

        var ex4 = new CleanAndJerk(DeficitRomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 12, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(BoxJump)
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
                new(3, ex1A, ex1B, ex1C),
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
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(Clean, FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2, 2], Sets = 4 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4 },
                new SingleRepeat { Percent = 0.6, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
            ]
        };

        var ex4 = new CleanAndJerk(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = [8, 8], Sets = 5 }
            ]
        };

        var ex5 = new Accessory(BoxJump)
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
                new(3, ex1A, ex1B, ex1C),
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
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new BackSquat(BackSquatNarrowFeet)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 8, Sets = 5 }
            ]
        };

        var ex3 = new CleanAndJerk(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 8, Sets = 5 }
            ]
        };

        var ex4 = new Accessory(BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 5, Sets = 6 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession1_4()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1C = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 5 }
            ]
        };

        var ex3 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 3 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 2], Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession2_1()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new MultiSnatch(PowerSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [3, 3], Sets = 4 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6 },
                new SingleRepeat { Percent = 0.6, Repeats = 6 },
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 5 }
            ]
        };

        var ex4 = new CleanAndJerk(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 10, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(BoxJump)
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
                new(3, ex1A, ex1B, ex1C),
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
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(Clean, FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2, 2], Sets = 4 }
            ]
        };

        var ex3 = new BackSquat(BackSquatPause)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4 },
                new SingleRepeat { Percent = 0.6, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 4 }
            ]
        };

        var ex4 = new BackSquat(BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 6 },
                new SingleRepeat { Percent = 0.7, Repeats = 6 },
                new SingleRepeat { Percent = 0.8, Repeats = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 6, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 6, Sets = 3 }
            ]
        };

        var ex5 = new CleanAndJerk(DeficitRomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.65, Repeats = 8, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(3, ex1A, ex1B, ex1C),
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
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 4 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 5 }
            ]
        };

        var ex3 = new CleanAndJerk(BackLunges)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = [8, 8], Sets = 5 }
            ]
        };

        var ex4 = new Accessory(BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 5 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession2_4()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1C = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 6 }
            ]
        };

        var ex3 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 2], Sets = 5 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession3_1()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new MultiSnatch(ExerciseType.Snatch, SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [3, 2, 2], Sets = 4 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3 },
                new SingleRepeat { Percent = 0.60, Repeats = 3 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new BackSquat(BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(BoxJump)
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
                new(3, ex1A, ex1B, ex1C),
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
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(PowerClean, FrontSquat, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2, 2], Sets = 4 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 4 },
                new SingleRepeat { Percent = 0.9, Repeats = 3 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 4 },
                new SingleRepeat { Percent = 1.0, Repeats = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3 },
                new SingleRepeat { Percent = 1.0, Repeats = 2 }
            ]
        };

        var ex4 = new CleanAndJerk(DeficitRomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 4 }
            ]
        };

        var ex5 = new CleanAndJerk(GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 8, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(3, ex1A, ex1B, ex1C),
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
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 8 },
                new SingleRepeat { Percent = 0.6, Repeats = 6 },
                new SingleRepeat { Percent = 0.7, Repeats = 5 },
                new SingleRepeat { Percent = 0.8, Repeats = 4 },
                new SingleRepeat { Percent = 0.9, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 5 },
                new SingleRepeat { Percent = 0.6, Repeats = 6 },
                new SingleRepeat { Percent = 0.5, Repeats = 8 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 1 },
                new SingleRepeat { Percent = 1.0, Repeats = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 1 }
            ]
        };

        var ex4 = new CleanAndJerk(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [6, 6], Sets = 4 }
            ]
        };

        var ex5 = new Accessory(BoxJump)
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
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession3_4()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1C = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 1, Sets = 3 }
            ]
        };

        var ex3 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 2], Sets = 5 },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 1], Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession4_1()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new MultiSnatch(PowerSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [3, 3], Sets = 4 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3 },
                new SingleRepeat { Percent = 0.600, Repeats = 3 },
                new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.800, Repeats = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.900, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.925, Repeats = 1, Sets = 2 }
            ]
        };

        var ex4 = new BackSquat(BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.70, Repeats = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 2 },
                new SingleRepeat { Percent = 0.95, Repeats = 2, Sets = 3 }
            ]
        };

        var ex5 = new CleanAndJerk(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 6, Sets = 3 }
            ]
        };

        var ex6 = new Accessory(BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 5 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5),
                new(ex6)
            ]
        };

        return session;
    }

    private static Session GetSession4_2()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(CleanPull, Clean, FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2, 2, 2], Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 3 },
                new SingleRepeat { Percent = 0.60, Repeats = 3 },
                new SingleRepeat { Percent = 0.70, Repeats = 3 },
                new SingleRepeat { Percent = 0.80, Repeats = 3 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 1 },
                new SingleRepeat { Percent = 1.05, Repeats = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 1 }
            ]
        };

        var ex4 = new CleanAndJerk(BackLunges)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [5, 5], Sets = 3 }
            ]
        };

        var ex5 = new CleanAndJerk(DeficitRomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(3, ex1A, ex1B, ex1C),
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
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1C = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new CleanAndJerk(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [5, 5], Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3 },
                new SingleRepeat { Percent = 0.600, Repeats = 3 },
                new SingleRepeat { Percent = 0.700, Repeats = 3 },
                new SingleRepeat { Percent = 0.800, Repeats = 3 },
                new SingleRepeat { Percent = 0.900, Repeats = 2, Sets = 3 },
                new SingleRepeat { Percent = 0.925, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 2 }
            ]
        };

        var ex5 = new Accessory(BoxJump)
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
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession4_4()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1C = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 3 }
            ]
        };

        var ex3 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 2], Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(3, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession5_1()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new MultiSnatch(ExerciseType.Snatch, SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [3, 2, 1], Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3 },
                new SingleRepeat { Percent = 0.600, Repeats = 3 },
                new SingleRepeat { Percent = 0.700, Repeats = 3 },
                new SingleRepeat { Percent = 0.800, Repeats = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 2 },
                new SingleRepeat { Percent = 0.900, Repeats = 2 },
                new SingleRepeat { Percent = 0.925, Repeats = 2, Sets = 3 }
            ]
        };

        var ex4 = new BackSquat(BackSquatPause)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            ]
        };

        var ex5 = new CleanAndJerk(GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 6, Sets = 3 }
            ]
        };

        var ex6 = new Accessory(BarbellSquatJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 6, Sets = 5 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(2, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5),
                new(ex6)
            ]
        };

        return session;
    }

    private static Session GetSession5_2()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(Clean, FrontSquat, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2, 2], Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.6, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(RomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 3 }
            ]
        };

        var ex5 = new Accessory(BoxJump)
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
                new(2, ex1A, ex1B),
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
        var ex1A = new Accessory(ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(GakkSquat)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new CleanAndJerk(BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [4, 4], Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 3 },
                new SingleRepeat { Percent = 0.600, Repeats = 3 },
                new SingleRepeat { Percent = 0.700, Repeats = 3 },
                new SingleRepeat { Percent = 0.800, Repeats = 3 },
                new SingleRepeat { Percent = 0.900, Repeats = 3 },
                new SingleRepeat { Percent = 1.000, Repeats = 3 },
                new SingleRepeat { Percent = 1.025, Repeats = 3 }
            ]
        };

        var ex4 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.500, Repeats = 2 },
                new SingleRepeat { Percent = 0.600, Repeats = 2 },
                new SingleRepeat { Percent = 0.700, Repeats = 2 },
                new SingleRepeat { Percent = 0.800, Repeats = 2 },
                new SingleRepeat { Percent = 0.900, Repeats = 2 },
                new SingleRepeat { Percent = 0.925, Repeats = 2 },
                new SingleRepeat { Percent = 0.950, Repeats = 2 }
            ]
        };

        var ex5 = new Accessory(BoxJump)
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
                new(2, ex1A, ex1B),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession5_4()
    {
        var ex1A = new Accessory(Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1C = new Accessory(BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex2 = new Snatch(ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 1, Sets = 2 }
            ]
        };

        var ex3 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 1], Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new(2, ex1A, ex1B, ex1C),
                new(ex2),
                new(ex3)
            ]
        };

        return session;
    }
}