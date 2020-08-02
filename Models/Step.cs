using System;
using System.Collections.Generic;
using System.Text;
using NodaTime;
using Npgsql.TypeHandlers;

namespace LoreDataAccessLibrary.Model
{
    public class Step
    {
        long StepId { get; set; }

        int StepType { get; set; }

        string StepName { get; set; }

        NodaTime.LocalDateTime StepCreateTime { get; set; }

        NodaTime.LocalDateTime StepUpdateTime { get; set; }

        UuidHandler StepUuid { get; set; }

        bool StepIsActive { get; set; }

        bool StepIsDeleted { get; set; }
    }
}
