using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Technique;

public abstract class BackTechniqueProgram : TrainingProgram
{
    protected static BaseExercise[] GetWarmup1(Stats stats, int hyperextension, int abs)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = hyperextension }]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var warmup = new BaseExercise[]
        {
            a, b
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup1(Stats stats, int hyperextension, int abs, int boxJump)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = hyperextension }]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var c = new Accessory(stats, BoxJump)
        {
            Repeats = [new SingleRepeat { Repeats = boxJump }]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup2(Stats stats, int reverseHyperextension, int abs)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = reverseHyperextension }]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var warmup = new BaseExercise[]
        {
            a, b
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup2(Stats stats, int reverseHyperextension, int abs, int boxJump)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = reverseHyperextension }]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var c = new Accessory(stats, BoxJump)
        {
            Repeats = [new SingleRepeat { Repeats = boxJump }]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup3(Stats stats, int reverseHyperextension, int boxJump)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = reverseHyperextension }]
        };

        var b = new Accessory(stats, BoxJump)
        {
            Repeats = [new SingleRepeat { Repeats = boxJump }]
        };

        var warmup = new BaseExercise[]
        {
            a, b
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup4(Stats stats, int hyperextension, int abs, int gakkSquat)
    {
        var a = new Accessory(stats, Hyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = hyperextension }]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var c = new Accessory(stats, GakkSquat)
        {
            Repeats = [new SingleRepeat { Repeats = gakkSquat }]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup5(Stats stats, int reverseHyperextension, int abs, int gakkSquat)
    {
        var a = new Accessory(stats, ReverseHyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = reverseHyperextension }]
        };

        var b = new Accessory(stats, Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var c = new Accessory(stats, GakkSquat)
        {
            Repeats = [new SingleRepeat { Repeats = gakkSquat }]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        return warmup;
    }
}