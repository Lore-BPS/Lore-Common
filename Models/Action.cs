using System;
using System.Collections.Generic;
using System.Text;
using Npgsql.Schema;
using Npgsql.TypeHandlers;

namespace LoreDataAccessLibrary.Model
{
    public class Action
    {
        long ActionId { get; set; }

        int ActionType { get; set; }

        string ActionName { get; set; }

        NodaTime.LocalDateTime ActionCreateTime { get; set; }

        NodaTime.LocalDateTime ActionUpdateTime { get; set; }

        UuidHandler ActionUuid { get; set; }

        bool ActionIsActive { get; set; }

        bool ActionIsDeleted { get; set; }


    }
}
