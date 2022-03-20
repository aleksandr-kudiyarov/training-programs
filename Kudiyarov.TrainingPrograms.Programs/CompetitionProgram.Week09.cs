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
    private static Session GetSession9_1()
    {
        var warmup = GetSnatchWarmUp2();

        var ex1Repeats = new List<Repeat>
        {
            new MultiRepeat { Percent = 0.50, Repeats = Array(1, 2), Sets = 2 },
            new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
            new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
            new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 2 },
            new MultiRepeat { Percent = 0.75, Repeats = Array(1, 1), Sets = 1 },
            new MultiRepeat { Percent = 0.80, Repeats = Array(1, 1), Sets = 2 }
        };

        ex1Repeats.AddRange(
            GetRange(0.85, 0.875, Array(1, 1), 4));

        var ex1 = new MultiSnatch(ExerciseType.Snatch, HangSnatchBelowKnees)
        {
            Repeats = ex1Repeats
        };

        var ex2 = new MultiSnatch(SnatchPull, HangSnatchBelowKnees)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.80, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.90, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.00, Repeats = Array(1, 2), Sets = 2 },
                new MultiRepeat { Percent = 1.05, Repeats = Array(1, 1), Sets = 2 }
            }
        };

        var ex3 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.70, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.80, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.85, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.90, Repeats = 2, Sets = 3 }
            }
        };

        var ex4 = new Accessory(BoxJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 6, Sets = 3 }
            }
        };

        var ex5 = new Accessory(KneesToElbows)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Repeats = 15, Sets = 4 }
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

    private static Session GetSession9_2()
    {
        var warmup = GetCleanAndJerkWarmUp1();

        var ex1 = new CleanAndJerk(Clean)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 }
            }
        };

        var ex2 = new CleanAndJerk(CleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.9, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.0, Repeats = 2, Sets = 3 },
                new SingleRepeat { Percent = 1.1, Repeats = 1, Sets = 1 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(warmup),
                new(ex1),
                new(ex2)
            }
        };

        return session;
    }

    private static Session GetSession9_3()
    {
        var warmup = GetSnatchWarmUp3();

        var ex1 = new Snatch(ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.50, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.60, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.65, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.70, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.75, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.80, Repeats = 2, Sets = 2 }
            }
        };

        var ex2 = new CleanAndJerk(Jerk)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.600, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.650, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.750, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.800, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.875, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.900, Repeats = 2, Sets = 1 }
            }
        };

        var ex3 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 1 },
                new SingleRepeat { Percent = 0.9, Repeats = 2, Sets = 2 }
            }
        };

        var ex4 = new CleanAndJerk(PushPress)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.6, Repeats = 3, Sets = 4 }
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

    private static Session GetSession9_4()
    {
        var ex1 = new MultiSnatch(PowerSnatch, ExerciseType.Snatch)
        {
            Repeats = new Repeat[]
            {
                new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
                new MultiRepeat { Percent = 0.60, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.65, Repeats = Array(1, 2), Sets = 1 },
                new MultiRepeat { Percent = 0.70, Repeats = Array(1, 1), Sets = 4 }
            }
        };

        var ex2Repeats = new List<Repeat>
        {
            new MultiRepeat { Percent = 0.50, Repeats = Array(2, 2), Sets = 2 },
            new MultiRepeat { Percent = 0.60, Repeats = Array(2, 2), Sets = 1 },
            new MultiRepeat { Percent = 0.65, Repeats = Array(2, 2), Sets = 1 },
            new MultiRepeat { Percent = 0.70, Repeats = Array(2, 1), Sets = 2 },
            new MultiRepeat { Percent = 0.80, Repeats = Array(2, 1), Sets = 2 },
            new MultiRepeat { Percent = 0.85, Repeats = Array(1, 1), Sets = 2 }
        };

        ex2Repeats.AddRange(
            GetRange(0.9, 0.925, Array(1, 1), 4));

        var ex2 = new MultiCleanAndJerk(Clean, Jerk)
        {
            Repeats = ex2Repeats
        };

        var ex3 = new CleanAndJerk(CleanPull)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.90, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 1.00, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 1.05, Repeats = 2, Sets = 3 }
            }
        };

        var ex4 = new BackSquat(ExerciseType.BackSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.700, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.800, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.850, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.900, Repeats = 3, Sets = 1 },
                new SingleRepeat { Percent = 0.925, Repeats = 3, Sets = 1 }
            }
        };

        var ex5 = new Accessory(BarbellSquatJump)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Weight = Stats.Bar, Repeats = 5, Sets = 3 }
            }
        };

        var ex6A = new Accessory(Plank)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Duration = Duration.FromSeconds(60) }
            }
        };

        var ex6B = new Accessory(Crunch)
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
                new(4, ex6A, ex6B)
            }
        };

        return session;
    }

    private static Session GetSession9_5()
    {
        var ex1 = new Snatch(MuscleSquatSnatch)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.5, Repeats = 3, Sets = 5 }
            }
        };

        var ex2 = new CleanAndJerk(FrontSquat)
        {
            Repeats = new Repeat[]
            {
                new SingleRepeat { Percent = 0.7, Repeats = 3, Sets = 2 },
                new SingleRepeat { Percent = 0.8, Repeats = 2, Sets = 2 },
                new SingleRepeat { Percent = 0.9, Repeats = 1, Sets = 1 }
            }
        };

        var ex3 = new CleanAndJerk(JerkSupport)
        {
            Repeats = new Repeat[]
            {
                new StaticRepeat { Percent = 1.1, Duration = Duration.FromSeconds(6), Sets = 2 }
            }
        };

        var session = new Session
        {
            Rounds = new Round[]
            {
                new(ex1),
                new(ex2),
                new(ex3)
            }
        };

        return session;
    }
}