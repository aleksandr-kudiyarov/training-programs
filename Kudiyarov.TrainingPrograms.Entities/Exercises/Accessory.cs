using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises;

public sealed class Accessory : BaseSingleExercise
{
    public Accessory(
        Stats stats,
        ExerciseType type) : base(GetWeight(stats, type), type)
    {
    }

    public EquipmentType EquipmentType => Type switch
    {
        ExerciseType.DumbbellFrenchPress => EquipmentType.Dumbbell,
        _ => EquipmentType.Barbell
    };

    private static double? GetWeight(
        Stats stats,
        ExerciseType type)
    {
        return type switch
        {
            // Back Squat
            ExerciseType.BackSplitSquat => stats.BackSplitSquat,

            // Lunges
            ExerciseType.BackLunges => stats.Lunges,
            ExerciseType.ForwardLunges => stats.Lunges,

            // Back
            ExerciseType.LateralPull => stats.LateralPull,
            ExerciseType.LateralPullReverseGrip => stats.LateralPull,

            // Press
            ExerciseType.Press => stats.Press,
            ExerciseType.SnatchPress => stats.Press,
            ExerciseType.AsymmetryPress => stats.Press,
            ExerciseType.OverheadSplitSquat => stats.Press,
            ExerciseType.PressInSitPosition => stats.Press,
            ExerciseType.PressInSplitPosition => stats.Press,
            ExerciseType.PressWithRubberBand => stats.Press,
            ExerciseType.SittingPress => stats.SnatchPress,
            ExerciseType.SnatchPressWithRubberBand => stats.SnatchPress,
            ExerciseType.SotsPress => stats.SnatchPress,

            // Bench Press
            ExerciseType.BenchPress => stats.BenchPress,
            ExerciseType.AsymmetryBenchPress => stats.BenchPress,
            ExerciseType.InclineBenchPress => stats.InclineBenchPress,
            ExerciseType.InclineBenchPressNarrowGrip => stats.BackSquat * 0.54,
            ExerciseType.InclineBenchPressWideGrip => stats.BackSquat * 0.54,
            ExerciseType.DeclineBenchPress => stats.BenchPress * 1.1,
            ExerciseType.SeatedBenchPress => stats.BenchPress,
            ExerciseType.DiscPress => stats.Press * 0.45,

            // Hands
            ExerciseType.BicepsCurl => stats.BicepsCurl,
            ExerciseType.DiscHammerCurls => stats.BicepsCurl,
            ExerciseType.BicepsCurlReverseGrip => stats.BicepsCurlRg,
            ExerciseType.FrenchPress => stats.FrenchPress,
            ExerciseType.DumbbellFrenchPress => stats.FrenchPress * 0.45,

            // Pull Up
            ExerciseType.PullUp => stats.PullUp,
            ExerciseType.ChinUp => stats.PullUp,

            // None
            _ => null
        };
    }
}