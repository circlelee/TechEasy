﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechEasy.CommandProcessor.Command
{
    public interface ICommandResults
    {
        ICommandResult[] Results { get; }

        bool Success { get; }
    }
}
