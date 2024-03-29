﻿using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises;

public abstract class BaseMultiExercise : BaseExercise
{
    private readonly ExerciseType[] _types;

    protected BaseMultiExercise(double? weight, ExerciseType[] types) : base(weight)
    {
        _types = types;
    }

    public override string Name => string.Join(" + ", _types.Select(GetName));
}