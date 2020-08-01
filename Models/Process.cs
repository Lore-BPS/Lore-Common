using System;
using System.Collections.Generic;
using System.Text;
using NodaTime;
using Npgsql.TypeHandlers;

namespace Lore_EF_DB_Structure.Model
{
    public class Process
    {
        long ProcessId { get; set; }

        int ProcessType { get; set; }

        string ProcessName { get; set; }

        NodaTime.LocalDateTime ProcessCreateTime { get; set; }

        NodaTime.LocalDateTime ProcessUpdateTime { get; set; }

        UuidHandler ProcessUuid { get; set; }

        bool ProcessIsActive { get; set; }

        bool ProcessIsDeleted { get; set; }

    }
}
