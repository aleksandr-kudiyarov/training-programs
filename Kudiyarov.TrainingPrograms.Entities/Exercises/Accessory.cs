using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises;

public sealed class Accessory : BaseSingleExercise
{
    public Accessory(ExerciseType type) : base(GetWeight(type), type)
    {
    }

    public EquipmentType EquipmentType => Type switch
    {
        ExerciseType.DumbbellFrenchPress => EquipmentType.Dumbbell,
        _ => EquipmentType.Barbell
    };

    private static double? GetWeight(ExerciseType type)
    {
        return type switch
        {
            // Back Squat
            ExerciseType.BackSplitSquat => Stats.BackSplitSquat,

            // Lunges
            ExerciseType.BackLunges => Stats.Lunges,
            ExerciseType.ForwardLunges => Stats.Lunges,

            // Back
            ExerciseType.LateralPull => Stats.LateralPull,
            ExerciseType.LateralPullReverseGrip => Stats.LateralPull,

            // Press
            ExerciseType.Press => Stats.Press,
            ExerciseType.SnatchPress => Stats.Press,
            ExerciseType.AsymmetryPress => Stats.Press,
            ExerciseType.OverheadSplitSquat => Stats.Press,
            ExerciseType.PressInSitPosition => Stats.Press,
            ExerciseType.PressInSplitPosition => Stats.Press,
            ExerciseType.PressWithRubberBand => Stats.Press,
            ExerciseType.SittingPress => Stats.SnatchPress,
            ExerciseType.SnatchPressWithRubberBand => Stats.SnatchPress,
            ExerciseType.SotsPress => Stats.SnatchPress,

            // Bench Press
            ExerciseType.BenchPress => Stats.BenchPress,
            ExerciseType.AsymmetryBenchPress => Stats.BenchPress,
            ExerciseType.InclineBenchPress => Stats.InclineBenchPress,
            ExerciseType.InclineBenchPressNarrowGrip => Stats.BackSquat * 0.54,
            ExerciseType.InclineBenchPressWideGrip => Stats.BackSquat * 0.54,
            ExerciseType.DeclineBenchPress => Stats.BenchPress * 1.1,
            ExerciseType.SeatedBenchPress => Stats.BenchPress,
            ExerciseType.DiscPress => Stats.Press * 0.45,

            // Hands
            ExerciseType.BicepsCurl => Stats.BicepsCurl,
            ExerciseType.DiscHammerCurls => Stats.BicepsCurl,
            ExerciseType.BicepsCurlReverseGrip => Stats.BicepsCurlRg,
            ExerciseType.FrenchPress => Stats.FrenchPress,
            ExerciseType.DumbbellFrenchPress => Stats.FrenchPress * 0.45,

            // Pull Up
            ExerciseType.PullUp => Stats.PullUp,
            ExerciseType.ChinUp => Stats.PullUp,

            // None
            _ => null
        };
    }
}