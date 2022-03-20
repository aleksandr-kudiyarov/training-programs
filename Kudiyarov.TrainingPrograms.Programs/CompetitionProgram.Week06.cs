﻿using Kudiyarov.TrainingPrograms.Entities.Entities;
using Kudiyarov.TrainingPrograms.Entities.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Entities.Repeats;
using NodaTime;
using static Kudiyarov.TrainingPrograms.Entities.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs;

public sealed partial class CompetitionProgram
{
    private static Session GetSession6_1()
    {
        var warmup = GetSnatchWarmUp2();

        var ex1 = new MultiSnatch(ExerciseType.Snatch, HangSnatchBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(SnatchPull, HangSnatchPullBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.8, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.9, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.0, Repeats = Array(1, 2), Sets = 3 }
            }
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 4 }
            }
        };

        var ex4 = new Accessory(Press)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.725, Repeats = 6, Sets = 4 }
            }
        };

        var ex5 = new Accessory(ToesToBar)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 10, Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession6_2()
    {
        var warmup = GetCleanAndJerkWarmUp2();

        var ex1 = new CleanAndJerk(DeficitClean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 3 }
            }
        };

        var ex2 = new MultiSnatch(SotsPress, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.3, Repeats = Array(4, 4), Sets = 5 }
            }
        };

        var ex3A = new Accessory(WristFlexion)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 10 }
            }
        };

        var ex3B = new Accessory(WristExtension)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 10 }
            }
        };

        var ex4 = new Accessory(Crunch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(warmup),
                new(ex1),
                new(ex2),
                new(3, ex3A, ex3B),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession6_3()
    {
        var warmup = GetSnatchWarmUp3();

        var ex1 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 1), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 3 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 3 }
            }
        };

        var ex2 = new Snatch(SnatchPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 2 }
            }
        };

        var ex3 = new CleanAndJerk(BackSplitSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.5, Repeats = Array(6, 6), Sets = 3 }
            }
        };

        var ex4 = new Accessory(GakkSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 12, Sets = 3 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4)
            }
        };

        return session;
    }

    private static Session GetSession6_4()
    {
        var warmup = GetCleanAndJerkWarmUp3();

        var ex1 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.75, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.80, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 3 }
            }
        };

        var ex2 = new CleanAndJerk(DeficitCleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.8, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.0, Repeats = 3, Sets = 3 }
            }
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.70, Repeats = 4 },
                new SingleRepeat { Percent = 0.80, Repeats = 4 },
                new SingleRepeat { Percent = 0.90, Repeats = 4 },
                new SingleRepeat { Percent = 1.00, Repeats = 4 },
                new SingleRepeat { Percent = 1.05, Repeats = 4 }
            }
        };

        var ex4 = new Accessory(BarbellSquatJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 6, Sets = 4 }
            }
        };

        var ex5 = new Accessory(Plank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(60), Sets = 4 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(warmup),
                new(ex1),
                new(ex2),
                new(ex3),
                new(ex4),
                new(ex5)
            }
        };

        return session;
    }

    private static Session GetSession6_5()
    {
        var ex1 = new Snatch(HipSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 4 }
            }
        };

        var ex2 = new MultiSnatch(SnatchPushPress, SnatchBalance, OverheadSquat)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(2, 2, 2), Sets = 3 }
            }
        };

        var ex3 = new Snatch(SnatchPushPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 3 },
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.95, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 1 }
            }
        };

        var ex4 = new Accessory(BoxJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 8, Sets = 4 }
            }
        };

        var ex5 = new Accessory(CalfRise)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 20, Sets = 2 }
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