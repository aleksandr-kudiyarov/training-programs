namespace Kudiyarov.TrainingPrograms.Entities;

public record Stats
{
    // https://www.t-nation.com/training/know-your-ratios-destroy-weaknesses

    public double Snatch => 82.5;
    public double CleanAndJerk => Snatch / 0.825;
    public double BackSquat => CleanAndJerk * 1.25;
    public double Deadlift => BackSquat * 1.2;
    public double BenchPress => BackSquat * 0.75;
    public double PushPress => BackSquat * 0.6375;
    public double InclineBenchPress => BackSquat * 0.6;
    public double Press => BackSquat * 0.45;

    // https://www.t-nation.com/training/know-your-ratios-destroy-weaknesses

    public double SnatchPress => Press * 0.825;
    public double BenchBackSquat => BackSquat * 1.1;
    public double FrontSquat => BackSquat * 0.85;
    public double BicepsCurl => BackSquat * 0.3;
    public double FrenchPress => BicepsCurl;
    public double BicepsCurlRg => BackSquat * 0.2625;
    public double BackSplitSquat => BackSquat / 2;
    public double SnatchDeadlift => BackSquat * 0.9;
    public double RomanianDeadlift => Deadlift * 0.55; // ?
    public double LateralPull => RomanianDeadlift; // ?
    public double PullUp => BackSquat * 0.675;
    public double Lunges => BackSplitSquat;
    private double MediumGripPull => (Snatch + CleanAndJerk) / 2 * PullFactor;
    public double DeficitMediumGripPull => MediumGripPull * DeficitFactor;
    private double PullFactor => 1.1;
    private double DeficitFactor => 0.9;
}