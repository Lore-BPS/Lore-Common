using System;
using System.Collections.Generic;
using System.Text;
using NodaTime;
using Npgsql.TypeHandlers;

namespace LoreDataAccessLibrary.Model
{
    public class BackendServers
    {

        long BackendServersId { get; set; }

        int BackendServersType { get; set; }

        string BackendServersName { get; set; }

        NodaTime.LocalDateTime BackendServersCreateTime { get; set; }

        NodaTime.LocalDateTime BackendServersUpdateTime { get; set; }

        UuidHandler BackendServersUuid { get; set; }

        bool BackendServersIsActive { get; set; }

        bool BackendServersIsDeleted { get; set; }

    }
}
