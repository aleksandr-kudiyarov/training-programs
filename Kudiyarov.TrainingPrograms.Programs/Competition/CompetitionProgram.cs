using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Exercises.CleanAndJerk;
using Kudiyarov.TrainingPrograms.Entities.Exercises.Snatch;
using Kudiyarov.TrainingPrograms.Entities.Repeats;
using static Kudiyarov.TrainingPrograms.Entities.Enums.ExerciseType;

namespace Kudiyarov.TrainingPrograms.Programs.Competition;

public sealed partial class CompetitionProgram : TrainingProgram
{
    public override ProgramType Type => ProgramType.Competition;
    public override string Name => "Competition Program";

    protected override IReadOnlyList<Func<Stats, Session>> GetSessions()
    {
        var sessions = new[]
        {
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5,
            GetSession2_1, GetSession2_2, GetSession2_3, GetSession2_4, GetSession2_5,
            GetSession3_1, GetSession3_2, GetSession3_3, GetSession3_4, GetSession3_5,
            GetSession4_1, GetSession4_2, GetSession4_3, GetSession4_4, GetSession4_5,
            GetSession5_1, GetSession5_2, GetSession5_3, GetSession5_4, GetSession5_5,
            GetSession6_1, GetSession6_2, GetSession6_3, GetSession6_4, GetSession6_5,
            GetSession7_1, GetSession7_2, GetSession7_3, GetSession7_4, GetSession7_5,
            GetSession8_1, GetSession8_2, GetSession8_3, GetSession8_4, GetSession8_5,
            GetSession9_1, GetSession9_2, GetSession9_3, GetSession9_4, GetSession9_5,
            GetSession10_1, GetSession10_2, GetSession10_3, GetSession10_4, GetSession10_5,
            GetSession11_1, EmptySession, GetSession11_3, GetSession11_4, GetSession11_5,
            GetSession12_1, EmptySession, GetSession12_3, GetSession12_4, GetSession12_5,
            GetSession13_1, EmptySession, GetSession13_3, GetSession13_4, EmptySession,
            GetSession14_1, EmptySession, GetSession14_3, EmptySession, GetSession14_5
        };

        return sessions;
    }

    private static BaseExercise[] GetSnatchWarmUp1(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex2 = new MultiSnatch(stats, SnatchPushPress, SnatchBalance, OverheadSquat)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.3, Repeats = Array(4, 4, 4), Sets = 3 }
            ]
        };

        var result = new BaseExercise[] { ex1, ex2 };
        return result;
    }

    private static BaseExercise[] GetSnatchWarmUp2(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchPullFromBlocks)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 6, Sets = 4 }
            ]
        };

        var result = new BaseExercise[] { ex1, ex2 };
        return result;
    }

    private static BaseExercise[] GetSnatchWarmUp3(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex2 = new Snatch(stats, SnatchOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 4, Sets = 4 }
            ]
        };

        var result = new BaseExercise[] { ex1, ex2 };
        return result;
    }

    private static BaseExercise[] GetCleanAndJerkWarmUp1(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, FrontSquat)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 6, Sets = 3 }
            ]
        };

        var result = new BaseExercise[] { ex1, ex2 };
        return result;
    }

    private static BaseExercise[] GetCleanAndJerkWarmUp2(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex2 = new CleanAndJerk(stats, CleanOnPlates)
        {
            Repeats =
            [
                new SingleRepeat { Percent = 0.3, Repeats = 4, Sets = 4 }
            ]
        };

        var result = new BaseExercise[] { ex1, ex2 };
        return result;
    }

    private static BaseExercise[] GetCleanAndJerkWarmUp3(Stats stats)
    {
        var ex1 = new Accessory(stats, Hyperextension)
        {
            Repeats =
            [
                new SingleRepeat { Repeats = 15, Sets = 2 }
            ]
        };

        var ex2 = new MultiCleanAndJerk(stats, MuscleClean, FrontSquat, Press)
        {
            Repeats =
            [
                new MultiRepeat { Percent = 0.3, Repeats = Array(4, 4, 4), Sets = 3 }
            ]
        };

        var result = new BaseExercise[] { ex1, ex2 };
        return result;
    }
}