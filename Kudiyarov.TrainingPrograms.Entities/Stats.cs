namespace Kudiyarov.TrainingPrograms.Entities;

public static class Stats
{
    // https://www.t-nation.com/training/know-your-ratios-destroy-weaknesses

    public const double Snatch = 77.5;
    public const double CleanAndJerk = Snatch / 0.825;
    public const double BackSquat = CleanAndJerk * 1.25;
    public const double Deadlift = BackSquat * 1.2;
    public const double BenchPress = BackSquat * 0.75;
    public const double PushPress = BackSquat * 0.6375;
    public const double InclineBenchPress = BackSquat * 0.6;
    public const double Press = BackSquat * 0.45;

    // https://www.t-nation.com/training/know-your-ratios-destroy-weaknesses

    public const double BenchBackSquat = BackSquat * 1.1;
    public const double FrontSquat = BackSquat * 0.85;
    public const double BicepsCurl = BackSquat * 0.3;
    public const double FrenchPress = BicepsCurl;
    public const double BicepsCurlRg = BackSquat * 0.2625;
    public const double BackSplitSquat = BackSquat / 2;
    public const double SnatchDeadlift = BackSquat * 0.9;
    public const double RomanianDeadlift = Deadlift * 0.55; // ?
    public const double LateralPull = RomanianDeadlift; // ?
    public const double PullUp = BackSquat * 0.675;
    public const double Lunges = BackSplitSquat;
    private const double MediumGripPull = (Snatch + CleanAndJerk) / 2 * PullFactor;
    public const double DeficitMediumGripPull = MediumGripPull * DeficitFactor;
    private const double PullFactor = 1.1;
    private const double DeficitFactor = 0.9;
}