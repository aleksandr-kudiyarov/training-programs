﻿using System;
using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;
using Core.Entities.Exercises;
using Core.Entities.Repeats;
using static Core.Entities.Enums.ExerciseType;

namespace Core.TrainingPrograms
{
    public class CompetitionProgram : BaseTrainingProgram
    {
        private static readonly IReadOnlyList<Func<Session>> Sessions = new Func<Session>[]
        {
            GetSession1_1, GetSession1_2, GetSession1_3, GetSession1_4, GetSession1_5
        };

        public CompetitionProgram() : base(Sessions)
        {
        }

        public override ProgramType Type => ProgramType.Competition;
        public override string Name => "Competition Program";

        private static Session GetSession1_1()
        {
            var warmup = GetSnatchWarmUp1();

            var ex1 = new Snatch(HangSnatchBelowKnees, HangSnatchAboveKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.65, Repeats = new[] {2, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {2, 1}, Sets = 4}
                }
            };

            var ex2 = new Snatch(SnatchPull, HangSnatchPullBelowKnees)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.8, Repeats = new[] {1, 3}, Sets = 4}
                }
            };

            var ex3 = new BackSquat(ExerciseType.BackSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 5, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 5, Sets = 4}
                }
            };

            var ex4 = new Snatch(SotsPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 12, Sets = 3}
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

        private static Session GetSession1_2()
        {
            var ex1 = new Snatch(MuscleSquatSnatch, OverheadSquat)
            {
                Repeats = GetRange(0.3, 0.35, 4, new[] {4, 4})
            };

            var ex2 = new CleanAndJerk(DeficitRomanianDeadlift)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.4, Repeats = 6, Sets = 3}
                }
            };

            var ex3 = new CleanAndJerk(PushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4, Sets = 5}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 4}
                }
            };

            var ex5 = new Accessory(Crunch)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 3}
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
                    new(ex5)
                }
            };

            return session;
        }

        private static Session GetSession1_3()
        {
            var warmup = GetCleanAndJerkWarmUp3();

            var ex1 = new CleanAndJerk(CleanFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.65, Repeats = 3, Sets = 2},
                    new SingleRepeat {Percent = 0.7, Repeats = 2, Sets = 3}
                }
            };

            var ex2 = new CleanAndJerk(CleanPullFromBlocks)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.7, Repeats = 4, Sets = 1},
                    new SingleRepeat {Percent = 0.8, Repeats = 4, Sets = 3},
                    new SingleRepeat {Percent = 0.9, Repeats = 3, Sets = 2}
                }
            };

            var ex3 = new CleanAndJerk(FrontSquat, Jerk)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.65, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 2}, Sets = 3}
                }
            };

            var ex4 = new Accessory(CalfRise)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 20, Sets = 2}
                }
            };

            var ex5 = new Accessory(KneesToElbows)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 12, Sets = 3}
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

        private static Session GetSession1_4()
        {
            var warmup = GetCleanAndJerkWarmUp1();

            var ex1 = new CleanAndJerk(PowerClean, PowerCleanBelowKnee)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {1, 3}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {1, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.65, Repeats = new[] {1, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 1}, Sets = 5}
                }
            };

            var ex2 = new CleanAndJerk(DeficitCleanPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.7, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.9, Repeats = 3, Sets = 3}
                }
            };

            var ex3 = new Snatch(SnatchPushPress)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 6, Sets = 3}
                }
            };

            var ex4 = new Accessory(BoxJump)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 8, Sets = 4}
                }
            };

            var ex5A = new Accessory(WristFlexion)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Weight = Stats.Bar, Repeats = 10}
                }
            };

            var ex5B = new Accessory(WristExtension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Weight = Stats.Bar, Repeats = 10}
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
                    new(2, ex5A, ex5B)
                }
            };

            return session;
        }

        private static Session GetSession1_5()
        {
            var ex1 = new Snatch(PowerSnatch, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.5, Repeats = new[] {2, 2}, Sets = 2},
                    new MultiRepeat {Percent = 0.6, Repeats = new[] {2, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.65, Repeats = new[] {2, 1}, Sets = 2},
                    new MultiRepeat {Percent = 0.7, Repeats = new[] {1, 1}, Sets = 4}
                }
            };

            var ex2 = new Snatch(MediumGripPull)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.7, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.8, Repeats = 4, Sets = 4}
                }
            };

            var ex3 = new BackSquat(BackSquatNarrowFeet)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.5, Repeats = 4, Sets = 2},
                    new SingleRepeat {Percent = 0.6, Repeats = 4, Sets = 4}
                }
            };

            var ex4 = new Snatch(SnatchPressWithRubberBand)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 8, Sets = 4}
                }
            };

            var ex5 = new Accessory(Plank)
            {
                Repeats = new Repeat[]
                {
                    new StaticRepeat {Time = TimeSpan.FromSeconds(45), Sets = 4}
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
                    new(ex5)
                }
            };

            return session;
        }

        private static BaseExercise[] GetSnatchWarmUp1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 2}
                }
            };

            var ex2 = new Snatch(SnatchPushPress, SnatchBalance, OverheadSquat)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.3, Repeats = new[] {4, 4, 4}, Sets = 3}
                }
            };

            var result = new BaseExercise[] {ex1, ex2};
            return result;
        }

        private static BaseExercise[] GetCleanAndJerkWarmUp1()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 2}
                }
            };

            var ex2 = new CleanAndJerk(FrontSquat)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Percent = 0.3, Repeats = 6, Sets = 3}
                }
            };

            var result = new BaseExercise[] {ex1, ex2};
            return result;
        }

        private static BaseExercise[] GetCleanAndJerkWarmUp3()
        {
            var ex1 = new Accessory(Hyperextension)
            {
                Repeats = new Repeat[]
                {
                    new SingleRepeat {Repeats = 15, Sets = 2}
                }
            };

            var ex2 = new CleanAndJerk(MuscleClean, FrontSquat, Press)
            {
                Repeats = new Repeat[]
                {
                    new MultiRepeat {Percent = 0.3, Repeats = new[] {4, 4, 4}, Sets = 3}
                }
            };

            var result = new BaseExercise[] {ex1, ex2};
            return result;
        }
    }
}