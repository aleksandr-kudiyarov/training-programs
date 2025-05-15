using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Technique;

public abstract class BackTechniqueProgram : TrainingProgram
{
    protected static BaseExercise[] GetWarmup1(int hyperextension, int abs)
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = hyperextension }]
        };

        var b = new Accessory(Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var warmup = new BaseExercise[]
        {
            a, b
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup1(int hyperextension, int abs, int boxJump)
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = hyperextension }]
        };

        var b = new Accessory(Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var c = new Accessory(BoxJump)
        {
            Repeats = [new SingleRepeat { Repeats = boxJump }]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup2(int reverseHyperextension, int abs)
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = reverseHyperextension }]
        };

        var b = new Accessory(Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var warmup = new BaseExercise[]
        {
            a, b
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup2(int reverseHyperextension, int abs, int boxJump)
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = reverseHyperextension }]
        };

        var b = new Accessory(Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var c = new Accessory(BoxJump)
        {
            Repeats = [new SingleRepeat { Repeats = boxJump }]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup3(int reverseHyperextension, int boxJump)
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = reverseHyperextension }]
        };

        var b = new Accessory(BoxJump)
        {
            Repeats = [new SingleRepeat { Repeats = boxJump }]
        };

        var warmup = new BaseExercise[]
        {
            a, b
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup4(int hyperextension, int abs, int gakkSquat)
    {
        var a = new Accessory(Hyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = hyperextension }]
        };

        var b = new Accessory(Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var c = new Accessory(GakkSquat)
        {
            Repeats = [new SingleRepeat { Repeats = gakkSquat }]
        };

        var warmup = new BaseExercise[]
        {
            a, b, c
        };

        return warmup;
    }

    protected static BaseExercise[] GetWarmup5(int reverseHyperextension, int abs, int gakkSquat)
    {
        var a = new Accessory(ReverseHyperextension)
        {
            Repeats = [new SingleRepeat { Repeats = reverseHyperextension }]
        };

        var b = new Accessory(Abs)
        {
            Repeats = [new SingleRepeat { Repeats = abs }]
        };

        var c = new Accessory(GakkSquat)
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