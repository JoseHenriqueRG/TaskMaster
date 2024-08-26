﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster.Domain.Entities
{
    public enum Status
    {
        Pending,
        InProgress,
        Completed
    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }
}
