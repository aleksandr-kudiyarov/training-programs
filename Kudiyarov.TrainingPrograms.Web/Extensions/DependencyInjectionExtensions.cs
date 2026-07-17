using Kudiyarov.TrainingPrograms.Bll;
using Kudiyarov.TrainingPrograms.Dal.Interfaces;
using Kudiyarov.TrainingPrograms.Dal.Memory;
using Kudiyarov.TrainingPrograms.Programs;
using Kudiyarov.TrainingPrograms.Programs.Competition;
using Kudiyarov.TrainingPrograms.Programs.Strength;
using Kudiyarov.TrainingPrograms.Programs.Technique;

namespace Kudiyarov.TrainingPrograms.Web.Extensions;

public static class DependencyInjectionExtensions
{
    extension(IServiceCollection services)
    {
        public void AddApplicationServices()
        {
            services.AddSingleton<TrainingProgramLogic>();
            services.AddSingleton<PercentageLogic>();
            services.AddSingleton<IProgramRepository, ProgramRepository>();
            services.AddPrograms();
        }

        private void AddPrograms()
        {
            services.AddSingleton<TrainingProgram, CompetitionProgram>();
            services.AddSingleton<TrainingProgram, DeadliftProgram>();
            services.AddSingleton<TrainingProgram, LegsProgram>();
            services.AddSingleton<TrainingProgram, MuscleGainProgram>();
            services.AddSingleton<TrainingProgram, PullAndSquatProgram>();
            services.AddSingleton<TrainingProgram, SnatchProgram>();
            services.AddSingleton<TrainingProgram, CleanProgram>();
            services.AddSingleton<TrainingProgram, JerkProgram>();
            services.AddSingleton<TrainingProgram, SpeedProgram>();
            services.AddSingleton<TrainingProgram, BodybuildingProgram>();
        }
    }
}
