﻿using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Enums;
using Core.TrainingPrograms;

namespace Core.Dal.Interfaces
{
    public interface IProgramRepository
    {
        IEnumerable<BaseTrainingProgram> Get();

        BaseTrainingProgram Get(ProgramType type);

        Session Get(ProgramType type, int day);
    }
}