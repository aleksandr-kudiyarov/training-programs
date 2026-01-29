using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Strength;

public sealed class PullAndSquatProgram : TrainingProgram
{
    public override string Name => "Pull and Squat Program";

    protected override IReadOnlyList<Func<Stats, Session>> GetSessions()
    {
        return
        [
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4, GetSession3_5,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4, GetSession4_5,
            GetSession5_1, GetSession5_2, GetSession5_3, GetSession5_4, GetSession5_5,
            GetSession6_1, EmptySession, GetSession6_3, GetSession6_4, GetSession6_5
        ];
    }

    private static Session GetSession1_1(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex2 = new Snatch(stats, MuscleSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 5, Sets = 3 }
            ]
        };

        var ex3 = new MultiSnatch(stats, SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.6, Repeats = [1, 3] },
                new MultiRepeat { Percent = 0.8, Repeats = [1, 3], Sets = 2 },
                new MultiRepeat { Percent = 0.9, Repeats = [1, 2], Sets = 3 }
            ]
        };

        var ex4 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5 },
                new SingleRepeat { Percent = 0.6, Repeats = 5, Sets = 4 }
            ]
        };

        var ex5 = new Snatch(stats, SotsPress)
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
                new Round(3, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession1_2(Stats stats)
    {
        var ex1A = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex1C = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, PowerClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, CleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 6, Sets = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [4, 4], Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B, ex1C),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession1_3(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex2 = new Snatch(stats, MuscleSquatSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 4 }
            ]
        };

        var ex3 = new Snatch(stats, DeficitSnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(stats, BoxJump)
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
                new Round(3, ex1A, ex1B),
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
        var ex1 = new Snatch(stats, PowerSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
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
                new Round(ex1),
                new Round(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession1_5(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, FrontSquat, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [1, 5], Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(stats, BackSquatNarrowFeet)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6 },
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 8, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession2_1(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex2 = new MultiSnatch(stats, MuscleSnatch, SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2, 4], Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, RomanianDeadlift)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6 },
                new SingleRepeat { Percent = 0.6, Repeats = 6 },
                new SingleRepeat { Percent = 0.7, Repeats = 6, Sets = 4 }
            ]
        };

        var ex4 = new BackSquat(stats, BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 3 }
            ]
        };

        var ex5 = new Snatch(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 4 }
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
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession2_2(Stats stats)
    {
        var ex1A = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex1C = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, PowerClean, FrontSquat, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2, 4], Sets = 4 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, DeficitCleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 4 },
                new SingleRepeat { Percent = 0.85, Repeats = 4, Sets = 3 },
                new SingleRepeat { Percent = 1.00, Repeats = 1 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 6, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B, ex1C),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession2_3(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex2 = new MultiSnatch(stats, PowerSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 3] },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 3], Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, HangSnatchPullAboveKnees)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 4 }
            ]
        };

        var ex4 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 4 }
            ]
        };

        var ex5 = new Accessory(stats, BarbellSquatJump)
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
                new Round(3, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession2_4(Stats stats)
    {
        var ex1 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 7 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 1] },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 2] },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 1], Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, JerkSupport)
        {
            Repeats =
            [
                new StaticRepeat { Percent = 0.80, Duration = TimeSpan.FromSeconds(6) },
                new StaticRepeat { Percent = 1.00, Duration = TimeSpan.FromSeconds(6) },
                new StaticRepeat { Percent = 1.05, Duration = TimeSpan.FromSeconds(6), Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(ex1),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession2_5(Stats stats)
    {
        var ex1A = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 12 }
            ]
        };

        var ex1C = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, MuscleSquatClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, CleanPullSlowlyDown)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 3 },
                new SingleRepeat { Percent = 1.0, Repeats = 4 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [6, 6], Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B, ex1C),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession3_1(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex2 = new Snatch(stats, MuscleSquatSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 4 }
            ]
        };

        var ex3 = new Snatch(stats, DeficitSnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 4 },
                new SingleRepeat { Percent = 0.70, Repeats = 4 },
                new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 3 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 3 }
            ]
        };

        var ex5 = new Snatch(stats, SnatchPushPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
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
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession3_2(Stats stats)
    {
        var ex1A = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex1C = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, CleanPull, Clean)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 2], Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, CleanPullSlowlyDown)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.70, Repeats = 3 },
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new Accessory(stats, BoxJump)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 5, Sets = 4 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B, ex1C),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession3_3(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex2 = new MultiSnatch(stats, PowerSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 4], Sets = 4 }
            ]
        };

        var ex3 = new Snatch(stats, MediumGripPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5 },
                new SingleRepeat { Percent = 0.7, Repeats = 5 },
                new SingleRepeat { Percent = 0.9, Repeats = 5, Sets = 3 }
            ]
        };

        var ex4 = new BackSquat(stats, BackSquatNarrowFeet)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4 },
                new SingleRepeat { Percent = 0.6, Repeats = 4 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 4 }
            ]
        };

        var ex5 = new Snatch(stats, SotsPress)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 4 }
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
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession3_4(Stats stats)
    {
        var ex1 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 5 }
            ]
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

    private static Session GetSession3_5(Stats stats)
    {
        var ex1A = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex1C = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, MuscleSquatClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 3 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, JerkSupport)
        {
            Repeats =
            [
                new StaticRepeat { Percent = 1.1, Duration = TimeSpan.FromSeconds(6), Sets = 4 }
            ]
        };

        var ex5 = new CleanAndJerk(stats, GoodMorningSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 8, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B, ex1C),
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
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex2 = new Snatch(stats, HipSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 3 }
            ]
        };

        var ex3 = new Snatch(stats, DeficitSnatchPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 1 }
            ]
        };

        var ex4 = new BackSquat(stats, BackSquatPause)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession4_2(Stats stats)
    {
        var ex1A = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex1C = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, CleanFromBlocks, FrontSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 3], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 3], Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 3], Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, CleanPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 4 },
                new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 1.1, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new Accessory(stats, BoxJump)
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
                new Round(3, ex1A, ex1B, ex1C),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession4_3(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex2 = new MultiSnatch(stats, MuscleSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [3, 3], Sets = 4 }
            ]
        };

        var ex3 = new MultiSnatch(stats, SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.70, Repeats = [1, 3] },
                new MultiRepeat { Percent = 0.80, Repeats = [1, 3], Sets = 2 },
                new MultiRepeat { Percent = 0.90, Repeats = [1, 2], Sets = 2 },
                new MultiRepeat { Percent = 1.00, Repeats = [1, 1], Sets = 2 },
                new MultiRepeat { Percent = 1.05, Repeats = [1, 1] }
            ]
        };

        var ex4 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 5 },
                new SingleRepeat { Percent = 0.9, Repeats = 4 },
                new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.1, Repeats = 1, Sets = 2 }
            ]
        };

        var ex5 = new CleanAndJerk(stats, JerkSupport)
        {
            Repeats =
            [
                new StaticRepeat { Percent = 1.10, Duration = TimeSpan.FromSeconds(6), Sets = 2 },
                new StaticRepeat { Percent = 1.15, Duration = TimeSpan.FromSeconds(6), Sets = 2 }
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
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession4_4(Stats stats)
    {
        var ex1A = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1C = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [2, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = [2, 1], Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 2], Sets = 2 },
                new MultiRepeat { Percent = 0.8, Repeats = [1, 1] }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, ex1A, ex1B, ex1C),
                new Round(ex2)
            ]
        };

        return session;
    }

    private static Session GetSession4_5(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, FrontSquat, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 3], Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 3], Sets = 3 }
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
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new BackSquat(stats, BenchBackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.85, Repeats = 6, Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession5_1(Stats stats)
    {
        var ex1A = new Accessory(stats, ReverseHyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1C = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Weight = Constants.Bar, Repeats = 6 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, MuscleSquatClean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, CleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.1, Repeats = 2, Sets = 2 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B, ex1C),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession5_2(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new MultiSnatch(stats, PowerSnatch, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [1, 4], Sets = 3 },
                new MultiRepeat { Percent = 0.6, Repeats = [1, 4], Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = [1, 1], Sets = 1 }
            ]
        };

        var ex3 = new MultiSnatch(stats, SnatchPushPress, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.7, Repeats = [3, 3], Sets = 2 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, BackSplitSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [4, 4], Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession5_3(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, PowerClean, FrontSquat, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2, 2], Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, DeficitCleanPull)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.50, Repeats = 4 },
                new SingleRepeat { Percent = 0.80, Repeats = 4 },
                new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 1.10, Repeats = 1 }
            ]
        };

        var ex4 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 2 }
            ]
        };

        var ex5 = new Accessory(stats, BarbellSquatJump)
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
                new Round(3, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4),
                new Round(ex5)
            ]
        };

        return session;
    }

    private static Session GetSession5_4(Stats stats)
    {
        var ex1 = new Snatch(stats, ExerciseType.Snatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 6 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, Clean, Jerk)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.4, Repeats = [2, 2], Sets = 4 }
            ]
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

    private static Session GetSession5_5(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex2 = new Snatch(stats, MuscleSquatSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 3 }
            ]
        };

        var ex4 = new CleanAndJerk(stats, JerkSupport)
        {
            Repeats =
            [
                new StaticRepeat { Percent = 1.0, Duration = TimeSpan.FromSeconds(4) },
                new StaticRepeat { Percent = 1.1, Duration = TimeSpan.FromSeconds(4) },
                new StaticRepeat { Percent = 1.2, Duration = TimeSpan.FromSeconds(4) }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(3, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession6_1(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, PowerClean, FrontSquat, PushPress)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2, 2], Sets = 3 }
            ]
        };

        var ex3 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 }
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
                new Round(2, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3),
                new Round(ex4)
            ]
        };

        return session;
    }

    private static Session GetSession6_3(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 10 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex2 = new MultiSnatch(stats, MuscleSnatch, SnatchBalance)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.5, Repeats = [2, 2], Sets = 3 }
            ]
        };

        var ex3 = new CleanAndJerk(stats, GoodMorning)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.4, Repeats = 4, Sets = 3 }
            ]
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }

    private static Session GetSession6_4(Stats stats)
    {
        var ex1 = new Snatch(stats, HipSnatch)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 3 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, Clean)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.5, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 2 }
            ]
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

    private static Session GetSession6_5(Stats stats)
    {
        var ex1A = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15 }
            ]
        };

        var ex1B = new Accessory(stats, Crunch)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 20 }
            ]
        };

        var ex2 = new BackSquat(stats, ExerciseType.BackSquat)
        {
            Repeats = SingleRepeat.GetMaxoutRepeats()
        };

        var ex3 = new Deadlift(stats, ExerciseType.Deadlift)
        {
            Repeats = SingleRepeat.GetMaxoutRepeats()
        };

        var session = new Session
        {
            Rounds =
            [
                new Round(2, ex1A, ex1B),
                new Round(ex2),
                new Round(ex3)
            ]
        };

        return session;
    }
}