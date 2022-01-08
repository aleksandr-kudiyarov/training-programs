﻿using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Entities.TrainingPrograms.Technique;

public sealed class SnatchProgram : BaseTrainingProgram
{
    public override ProgramType Type => ProgramType.Snatch;
    public override string Name => "Snatch Program";

    protected override IReadOnlyList<Func<Session>> GetSessions()
    {
        return new Func<Session>[]
        {
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4, GetSession3_5,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4, GetSession4_5,
            GetSession5_1
        };
    }

    private static Session GetSession1_1()
    {
        var warmup = GetWarmup1(10, 15, 5);

        var ex1 = new MultiSnatch(PowerSnatch, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 3 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 2 }
            }
        };

        var ex2 = new Snatch(SnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 3 }
            }
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            }
        };

        // todo ??
        var ex4 = new Accessory(SnatchPressWithRubberBand)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 6, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession1_2()
    {
        var warmup = GetWarmup2(15, 15);

        var ex1 = new Snatch(MuscleSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 1), Sets = 3 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1), Sets = 2 }
            }
        };

        var ex3 = new CleanAndJerk(GoodMorningSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 10, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }

    private static Session GetSession1_3()
    {
        var warmup = GetWarmup1(10, 15, 5);

        var ex1 = new Snatch(SnatchOnPlates)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 4, Sets = 3 }
            }
        };

        var ex2 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 4 }
            }
        };

        var ex3 = new Snatch(SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 }
            }
        };

        var ex4 = new Snatch(SnatchPullFromBlocks)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 6, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession1_4()
    {
        var warmup = GetWarmup1(10, 15, 5);

        var ex1 = new Accessory(ElbowsRotation)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 3 }
            }
        };

        var ex2 = new Accessory(HipCleanBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = 0, Repeats = 6, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(Clean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 3 }
            }
        };

        var ex4 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession1_5()
    {
        var warmup = GetWarmup2(15, 15);

        var ex1 = new MultiAccessory(SnatchBalance, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = 0, Repeats = Array(4, 4), Sets = 2 }
            }
        };

        var ex2 = new MultiSnatch(HipPowerSnatch, SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(2, 2), Sets = 3 }
            }
        };

        var ex3 = new Snatch(SnatchPushPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 3 }
            }
        };

        var ex4 = new Snatch(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession2_1()
    {
        var warmup = GetWarmup2(10, 15, 5);

        var ex1 = new MultiSnatch(MuscleSnatch, SnatchBalance, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = 0, Repeats = Array(4, 4, 4), Sets = 2 }
            }
        };

        var ex2 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch, SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1, 2), Sets = 3 }
            }
        };

        var ex3 = new MultiSnatch(ExerciseType.Snatch, HangSnatchBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.500, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.600, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.750, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.775, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.800, Repeats = Array(1, 1), Sets = 1 }
            }
        };

        var ex4 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.90, Repeats = Array(1, 3), Sets = 2 },
                new MultiRepeat { Percent = 1.00, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.05, Repeats = Array(1, 1), Sets = 1 }
            }
        };

        var ex5 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 9, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 7, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 5, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession2_2()
    {
        var warmup = GetWarmup1(15, 15);

        var ex1 = new Snatch(MuscleSquatSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 4 }
            }
        };

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 1 }
            }
        };

        var ex3 = new CleanAndJerk(GoodMorning)
        {
            Repeats = new Repeat[]
            {
                // TODO ??
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 3 }
            }
        };

        var ex4 = new Accessory(BarbellSquatJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 5, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession2_3()
    {
        var warmup = GetWarmup2(10, 15, 5);

        var ex1 = new Snatch(HipSnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = 0, Repeats = 8, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(SnatchPull, ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.500, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.600, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(2, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.750, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.775, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.800, Repeats = Array(2, 1), Sets = 1 }
            }
        };

        var ex3 = new MultiSnatch(SnatchPull, HangSnatchPullAboveKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 3), Sets = 3 },
                new MultiRepeat { Percent = 1.0, Repeats = Array(1, 3), Sets = 1 }
            }
        };

        var ex4 = new Snatch(OverheadSquatPause)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession2_4()
    {
        var warmup = GetWarmup2(10, 15, 5);

        var ex1 = new Accessory(ElbowsRotation)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 3 }
            }
        };

        var ex2 = new Accessory(HipCleanBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = 0, Repeats = 6, Sets = 3 }
            }
        };

        var ex3 = new MultiCleanAndJerk(PowerClean, FrontSquat)
        {
            Repeats = GetRange(0.5, 0.6, Array(2, 2), 3)
        };

        var ex4 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession2_5()
    {
        var warmup = GetWarmup1(15, 15);

        var ex1 = new Snatch(SnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = 0, Repeats = 6, Sets = 2 }
            }
        };

        var ex2 = new MultiSnatch(HipSnatch, SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 3 }
            }
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 1 }
            }
        };

        var ex4 = new MultiSnatch(SnatchPushPress, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 3), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 1), Sets = 1 }
            }
        };

        var ex5 = new Accessory(DeathJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 5, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession3_1()
    {
        var warmup = GetWarmup1(10, 15, 5);

        var ex1 = new MultiSnatch(MuscleSnatch, SnatchBalance, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = 0, Repeats = Array(4, 4, 4), Sets = 2 }
            }
        };

        var ex2 = new Snatch(SnatchFromBlocks)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 3 }
            }
        };

        var ex3 = new MultiSnatch(SnatchPushPress, SnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(3, 3), Sets = 1 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(3, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(3, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(3, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(3, 1), Sets = 2 }
            }
        };

        var ex4 = new Snatch(SnatchPullFromBlocks)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.70, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.10, Repeats = 1, Sets = 2 }
            }
        };

        var ex5 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 2 }
            }
        };

        var ex6 = new Snatch(SotsPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.3, Repeats = 8, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
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
        var warmup = GetWarmup2(15, 15);

        var ex1 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 2), Sets = 8 }
            }
        };

        var ex2 = new CleanAndJerk(GoodMorningSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 3 }
            }
        };

        var ex3 = new Accessory(ChickenJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }

    private static Session GetSession3_3()
    {
        var warmup = GetWarmup1(10, 15, 5);

        var ex1 = new MultiSnatch(HipSnatchBalance, SotsPress)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = 0, Repeats = Array(4, 4), Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(DeficitPowerSnatch, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.6, Repeats = Array(3, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.7, Repeats = Array(2, 1), Sets = 3 }
            }
        };

        var ex3 = new Snatch(DeficitSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 3 },
                new SingleRepeat { Percent = 0.800, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.825, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.850, Repeats = 1, Sets = 1 }
            }
        };

        var ex4 = new Snatch(DeficitSnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 4, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 4, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
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
        var warmup = GetWarmup1(10, 15, 5);

        var ex1 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 6, Sets = 3 }
            }
        };

        var ex2 = new CleanAndJerk(Clean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 2 }
            }
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }

    private static Session GetSession3_5()
    {
        var warmup = GetWarmup2(15, 15);

        var ex1 = new MultiSnatch(SnatchBalance, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = 0, Repeats = Array(4, 4), Sets = 3 }
            }
        };

        var ex2 = new Snatch(SnatchOnPlates)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 4, Sets = 3 }
            }
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 2 }
            }
        };

        var ex4 = new Snatch(SnatchPullFromBlocks)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 5, Sets = 4 }
            }
        };

        var ex5 = new Snatch(SnatchPushPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 4, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.95, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 1, Sets = 1 },
                new SingleRepeat { Percent = 1.05, Repeats = 1, Sets = 1 }
            }
        };

        var ex6 = new Accessory(DeathJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
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

    private static Session GetSession4_1()
    {
        var warmup = GetWarmup2(15, 15, 5);

        var ex1 = new MultiSnatch(MuscleSnatch, SnatchBalance, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = 0, Repeats = Array(3, 3, 3), Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
        {
            Repeats = GetRange(0.5, 0.6, Array(2, 1), 3)
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 1, Sets = 4 }
            }
        };

        var ex4 = new MultiSnatch(SnatchPullTillKnee, SnatchPullTillPower, SnatchPull)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.7, Repeats = Array(1, 1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 1, 1), Sets = 2 },
                new MultiRepeat { Percent = 1.0, Repeats = Array(1, 1, 1), Sets = 3 }
            }
        };

        var ex5 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 2 }
            }
        };

        var ex6 = new Accessory(SnatchPressWithRubberBand)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Intensity = Intensity.Light, Repeats = 5, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
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

    private static Session GetSession4_2()
    {
        var warmup = GetWarmup1(15, 15);

        var ex1 = new Snatch(MuscleSquatSnatch)
        {
            Repeats = GetRange(0.5, 0.6, 2, 3)
        };

        var ex2 = new MultiCleanAndJerk(FrontSquat, Jerk)
        {
            Repeats = GetRange(0.5, 0.6, Array(2, 1), 3)
        };

        var ex3 = new Accessory(BarbellSquatJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 5, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }

    private static Session GetSession4_3()
    {
        var warmup = GetWarmup2(15, 15, 5);

        var ex1 = new Snatch(HipSnatchBalance)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = 0, Repeats = 6, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(ExerciseType.Snatch, HangSnatchBelowKnees, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(2, 1, 2), Sets = 3 }
            }
        };

        var ex3 = new MultiSnatch(ExerciseType.Snatch, HangSnatchBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.500, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.600, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.700, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.800, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.850, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.875, Repeats = Array(1, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.900, Repeats = Array(1, 1), Sets = 1 }
            }
        };

        var ex4 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.90, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.00, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.05, Repeats = Array(1, 1), Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession4_4()
    {
        var warmup = GetWarmup2(15, 15, 5);

        var ex1 = new MultiCleanAndJerk(MuscleClean, FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Weight = 0, Repeats = Array(4, 4), Sets = 3 }
            }
        };

        var ex2 = new CleanAndJerk(PowerClean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 4 },
                new SingleRepeat { Percent = 0.8, Repeats = 4 },
                new SingleRepeat { Percent = 0.9, Repeats = 4 },
                new SingleRepeat { Percent = 1.0, Repeats = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(ex1),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }

    private static Session GetSession4_5()
    {
        var warmup = GetWarmup1(15, 15);

        var ex1 = new Snatch(SnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = 0, Repeats = 6, Sets = 2 }
            }
        };

        var ex2 = new Snatch(DeficitPowerSnatch)
        {
            Repeats = GetRange(0.5, 0.6, 3, 3)
        };

        var ex3 = new MultiSnatch(SnatchPull, ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 }
            }
        };

        var ex4 = new Accessory(ChickenJump)
        {
            Repeats = new[]
            {
                new SingleRepeat { Repeats = 5, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(3, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession5_1()
    {
        var warmup = GetWarmup1(10, 15);

        var ex1 = new Snatch(SnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = 0, Repeats = 6, Sets = 2 }
            }
        };

        var ex2 = new Snatch(SnatchOnPlates)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.4, Repeats = 3, Sets = 2 }
            }
        };

        var ex3 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.85, Repeats = 1, Sets = 2 },
                new SingleRepeat { Percent = 0.90, Repeats = 1, Sets = 3 }
            }
        };

        var ex4 = new MultiSnatch(SnatchPullTillKnee, SnatchPullTillPower)
        {
            Repeats = new[]
            {
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 1), Sets = 2 }
            }
        };

        var ex5 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 2 },
                new SingleRepeat { Percent = 0.7, Repeats = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(2, warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static BaseExercise[] GetWarmup1(int hyperextension, int abs, int boxJump)
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[] { new SingleRepeat { Repeats = hyperextension } }
        };

        var b = new Accessory(Abs)
        {
            Repeats = new Repeat[] { new SingleRepeat { Repeats = abs } }
        };

        var c = new Accessory(BoxJump)
        {
            Repeats = new Repeat[] { new SingleRepeat { Repeats = boxJump } }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        return warmup;
    }

    private static BaseExercise[] GetWarmup2(int reverseHyperextension, int abs, int boxJump)
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[] { new SingleRepeat { Repeats = reverseHyperextension } }
        };

        var b = new Accessory(Abs)
        {
            Repeats = new Repeat[] { new SingleRepeat { Repeats = abs } }
        };

        var c = new Accessory(BoxJump)
        {
            Repeats = new Repeat[] { new SingleRepeat { Repeats = boxJump } }
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        return warmup;
    }

    private static BaseExercise[] GetWarmup1(int hyperextension, int abs)
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats = new Repeat[] { new SingleRepeat { Repeats = hyperextension } }
        };

        var b = new Accessory(Abs)
        {
            Repeats = new Repeat[] { new SingleRepeat { Repeats = abs } }
        };

        var warmup = new BaseExercise[]
        {
            a, b
        };

        return warmup;
    }

    private static BaseExercise[] GetWarmup2(int reverseHyperextension, int abs)
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats = new Repeat[] { new SingleRepeat { Repeats = reverseHyperextension } }
        };

        var b = new Accessory(Abs)
        {
            Repeats = new Repeat[] { new SingleRepeat { Repeats = abs } }
        };

        var warmup = new BaseExercise[]
        {
            a, b
        };

        return warmup;
    }
}