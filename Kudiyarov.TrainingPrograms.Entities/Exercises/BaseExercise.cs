using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Repeats;

namespace Kudiyarov.TrainingPrograms.Entities.Exercises;

public abstract class BaseExercise
{
    protected BaseExercise(double? weight)
    {
        Weight = weight;
    }

    public abstract string Name { get; }
    public double? Weight { get; }
    public IReadOnlyList<Repeat> Repeats { get; set; } = [];
    public bool IsWarmupNeeded { get; init; }

    // TODO extract to WebUi
    protected static string GetName(ExerciseType type)
    {
        // Exercises
        const string snatch = "Snatch";
        const string clean = "Clean";
        const string jerk = "Jerk";
        const string squat = "Squat";
        const string backSquat = $"Back {squat}";
        const string frontSquat = $"Front {squat}";
        const string overheadSquat = $"Overhead {squat}";
        const string press = "Press";
        const string pushPress = $"Push {press}";
        const string snatchPress = $"{snatch} {press}";
        const string benchPress = $"Bench {press}";

        // Prefixes
        const string hang = "Hang";
        const string mediumGrip = "Medium Grip";
        const string power = "Power";

        // Suffixes
        const string block = "(from Blocks)";
        const string aboveKnees = "(above Knees)";
        const string belowKnees = "(below Knees)";
        const string deficit = "from Deficit";
        const string pull = "Pull";
        const string pause = "(with Pause)";
        const string rubber = "(with Rubber Band)";
        const string plates = "(on Plates)";
        const string withTwoStops = "with 2 Stops";

        return type switch
        {
            // Snatch
            ExerciseType.Snatch => snatch,
            ExerciseType.DeficitMediumGripPull => $"{mediumGrip} {pull} ({deficit})",
            ExerciseType.DeficitPowerSnatch => $"{power} {snatch} ({deficit})",
            ExerciseType.DeficitSnatch => $"{snatch} ({deficit})",
            ExerciseType.DeficitSnatchPull => $"{snatch} {pull} ({deficit})",
            ExerciseType.DeficitSnatchPullWith2Stops => $"{snatch} {pull} ({deficit}, {withTwoStops})",
            ExerciseType.HangPowerSnatch => $"{hang} {power} {snatch}",
            ExerciseType.HangSnatchAboveKnees => $"{hang} {snatch} {aboveKnees}",
            ExerciseType.HangSnatchBelowKnees => $"{hang} {snatch} {belowKnees}",
            ExerciseType.HangSnatchPullAboveKnees => $"{hang} {snatch} {pull} {aboveKnees}",
            ExerciseType.HangSnatchPullBelowKnees => $"{hang} {snatch} {pull} {belowKnees}",
            ExerciseType.HipSnatch => $"Hip {snatch}",
            ExerciseType.HipSnatchBalance => $"Hip {snatch} Balance",
            ExerciseType.HipPowerSnatch => $"Hip {power} {snatch}",
            ExerciseType.MediumGripPull => $"{mediumGrip} {pull}",
            ExerciseType.MuscleSnatch => $"Muscle {snatch}",
            ExerciseType.MuscleSquatSnatch => $"Muscle Squat {snatch}",
            ExerciseType.OverheadSquat => overheadSquat,
            ExerciseType.OverheadSquatPause => $"{overheadSquat} {pause}",
            ExerciseType.PowerSnatch => $"{power} {snatch}",
            ExerciseType.PowerSnatchAboveKnee => $"{power} {snatch} {aboveKnees}",
            ExerciseType.SnatchBalance => $"{snatch} Balance",
            ExerciseType.SnatchFromBlocks => $"{snatch} {block}",
            ExerciseType.SnatchOnPlates => $"{snatch} {plates}",
            ExerciseType.SnatchPull => $"{snatch} {pull}",
            ExerciseType.SnatchPullFromBlocks => $"{snatch} {pull} {block}",
            ExerciseType.SnatchPullTillKnee => $"{snatch} {pull} till Knee",
            ExerciseType.SnatchPullTillPower => $"{snatch} {pull} till Power Position",
            ExerciseType.SnatchPullWith2Stops => $"{snatch} {pull} ({withTwoStops})",
            ExerciseType.SnatchPushPress => $"{snatch} {pushPress}",
            ExerciseType.SotsPress => $"Sots {press}",
            ExerciseType.SotsPressPause => $"Sots {press} {pause}",

            // Clean
            ExerciseType.Clean => clean,
            ExerciseType.CleanFromBlocks => $"{clean} {block}",
            ExerciseType.CleanOnPlates => $"{clean} {plates}",
            ExerciseType.CleanPull => $"{clean} {pull}",
            ExerciseType.CleanPullFromBlocks => $"{clean} {pull} {block}",
            ExerciseType.CleanPullSlowlyDown => $"{clean} {pull} (Slowly Down)",
            ExerciseType.CleanPullTillPowerPosition => $"{clean} {pull} till Power Position",
            ExerciseType.CleanStretching => $"{clean} Stretching",
            ExerciseType.DeficitClean => $"Clean ({deficit})",
            ExerciseType.DeficitCleanPull => $"Clean {pull} ({deficit})",
            ExerciseType.HangCleanBelowKnee => $"Hang {clean} Below Knee",
            ExerciseType.HangCleanPullBelowKnee => $"Hang {clean} {pull} Below Knee",
            ExerciseType.HangPowerClean => $"Hang {power} {clean}",
            ExerciseType.HipCleanBalance => $"Hip {clean} Balance",
            ExerciseType.HipMuscleClean => $"Hip Muscle {clean}",
            ExerciseType.MuscleClean => $"Muscle {clean}",
            ExerciseType.MuscleSquatClean => $"Muscle Squat {clean}",
            ExerciseType.PowerClean => $"{power} {clean}",
            ExerciseType.PowerCleanBelowKnee => $"{power} {clean} Below Knee",

            // Jerk
            ExerciseType.Jerk => jerk,
            ExerciseType.JerkBehindTheNeck => $"{jerk} Behind the Neck",
            ExerciseType.JerkDrive => $"{jerk} Drive",
            ExerciseType.PauseJerkDrive => $"{jerk} Drive {pause}",
            ExerciseType.JerkDropBalance => $"{jerk} Drop Balance",
            ExerciseType.JerkSupport => $"{jerk} Support",
            ExerciseType.OverheadSplitSquat => $"Overhead split {squat}",
            ExerciseType.PauseJerk => $"{jerk} {pause}",
            ExerciseType.PowerJerk => $"{power} {jerk}",
            ExerciseType.PushPress => pushPress,
            ExerciseType.PushPressInSplit => $"{pushPress} in Split Position",
            ExerciseType.PausePushPress => $"{pushPress} {pause}",

            // Cluster
            ExerciseType.Cluster => "Cluster",
            ExerciseType.Thruster => "Thruster",

            // Front Squat
            ExerciseType.FrontSquat => frontSquat,
            ExerciseType.BoxFrontSquat => $"Box {frontSquat}",

            // Back Squat
            ExerciseType.BackSplitSquat => $"Back Split {squat}",
            ExerciseType.BackSquat => backSquat,
            ExerciseType.BackSquatPause => $"{backSquat} {pause}",
            ExerciseType.BackSquatNarrowFeet => $"{backSquat} (Narrow Feet)",
            ExerciseType.BenchBackSquat => $"Bench {backSquat}",
            ExerciseType.GakkSquat => $"Gakk {squat}",
            ExerciseType.HalfSquat => $"Half {squat}",
            ExerciseType.WallSquat => $"Wall {squat}",

            // Deadlift
            ExerciseType.Deadlift => "Deadlift",
            ExerciseType.AsymmetryDeadlift => "Asymmetry Deadlift",
            ExerciseType.DeadliftFromBlocks => $"Deadlift {block}",
            ExerciseType.DeficitDeadlift => $"Deadlift ({deficit})",
            ExerciseType.DeficitRomanianDeadlift => $"Romanian Deadlift ({deficit})",
            ExerciseType.RomanianDeadlift => "Romanian Deadlift",
            ExerciseType.SnatchDeadlift => $"{snatch} Deadlift",

            // ABS
            ExerciseType.Abs => "ABS",
            ExerciseType.CoreRotation => "Core Rotation",
            ExerciseType.Crunch => "Crunch",
            ExerciseType.KneesToElbows => "Knees to Elbows",
            ExerciseType.LegRaise => "Leg Raise",
            ExerciseType.MilitaryPlank => "Military Plank",
            ExerciseType.Plank => "Plank",
            ExerciseType.ReversePlank => "Reverse Plank",
            ExerciseType.ToesToBar => "Toes to Bar",

            // Accessory
            ExerciseType.DiscFrontRise => "Disc Front Rise",
            ExerciseType.DiscRussianTwist => "Disc Russian Twist",
            ExerciseType.SingleLegReach => "Single Leg Reach",
            ExerciseType.SquatReach => $"{squat} Reach",

            // Back
            ExerciseType.DiscLateralPull => "Disc Lateral Pull",
            ExerciseType.GluteBridge => "GluteBridge",
            ExerciseType.Hyperextension => "Hyperextension",
            ExerciseType.LateralPull => "Lateral Pull",
            ExerciseType.LateralPullReverseGrip => "Lateral Pull Reverse Grip",
            ExerciseType.ReverseHyperextension => "Reverse Hyperextension",
            ExerciseType.Superman => "Superman",
            ExerciseType.SupermanCrossed => "Superman (Crossed)",
            ExerciseType.SupermanSwim => "Superman (Swim)",

            // Bench Press
            ExerciseType.AsymmetryBenchPress => $"Asymmetry {benchPress}",
            ExerciseType.BenchPress => benchPress,
            ExerciseType.DeclineBenchPress => $"Decline {benchPress}",
            ExerciseType.DiscBridgePullover => "Disc Bridge Pullover",
            ExerciseType.InclineBenchPress => $"Incline {benchPress}",
            ExerciseType.InclineBenchPressNarrowGrip => $"Incline {benchPress} Narrow Grip",
            ExerciseType.InclineBenchPressWideGrip => $"Incline {benchPress} Wide Grip",
            ExerciseType.SeatedBenchPress => $"Seated {benchPress}",

            // Biceps
            ExerciseType.BicepsCurl => "Biceps Curl",
            ExerciseType.BicepsCurlReverseGrip => "Biceps Curl Reverse Grip",
            ExerciseType.DiscHammerCurls => "Disc Hammer Curl",

            // Calf
            ExerciseType.CalfRise => "Calf Rise",

            // Good Morning
            ExerciseType.GoodMorning => "Good Morning",
            ExerciseType.GoodMorningSquat => $"Good Morning + {squat}",

            // Jumps
            ExerciseType.BarbellSquatJump => $"Barbell {squat} Jump",
            ExerciseType.BoxJump => "Box Jump",
            ExerciseType.ChickenJump => "Chicken Jump",
            ExerciseType.DeathJump => "Death Jump",
            ExerciseType.KoreanJump => "Korean Jump",

            // Lunges
            ExerciseType.BackLunges => "Back Lunges",
            ExerciseType.ForwardLunges => "Forward Lunges",

            // Press
            ExerciseType.AsymmetryPress => "Asymmetry Press",
            ExerciseType.DiscPress => $"Disc {press}",
            ExerciseType.Press => press,
            ExerciseType.PressInSitPosition => $"{press} in Sit Position",
            ExerciseType.PressInSplitPosition => $"{press} in Split Position",
            ExerciseType.PressWithRubberBand => $"{press} {rubber}",
            ExerciseType.SnatchPressWithRubberBand => $"{snatchPress} {rubber}",
            ExerciseType.SittingPress => $"Sitting {press}",

            // Pull Up
            ExerciseType.ChinUp => "Chin Up",
            ExerciseType.PullUp => "Pull Up",

            // Push Up
            ExerciseType.PushUp => "Push Up",
            ExerciseType.ReversePushUp => "Reverse Push Up",
            ExerciseType.WidePushUp => "Wide Push Up",

            // Shoulders
            ExerciseType.ReverseFly => "Reverse Fly",
            ExerciseType.Halo => "Halo",
            ExerciseType.LateralRaise => "Lateral Raise",
            ExerciseType.LuRaises => "Lu Raises",

            // Triceps
            ExerciseType.DumbbellFrenchPress => $"Dumbbell French {press}",
            ExerciseType.FrenchPress => "French Press",
            ExerciseType.TricepsExtension => "Triceps Extension",

            // Elbows
            ExerciseType.ElbowsRotation => "Elbows Rotation",
            ExerciseType.ElbowsRotationRackSupport => "Elbows Rotation (with Rack Support)",

            // Wrists
            ExerciseType.DiscJuggling => "Disc Juggling",
            ExerciseType.WristExtension => "Wrist Extension",
            ExerciseType.WristFlexion => "Wrist Flexion",
            ExerciseType.WristRoll => "Wrist Roll",

            _ => throw new ArgumentOutOfRangeException(nameof(type), "Type is not defined")
        };
    }
}