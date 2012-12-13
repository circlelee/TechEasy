using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechEasy.CommandProcessor.Command
{
    public class CommandResult : ICommandResult
    {
        public CommandResult(bool success)
        {
            this.Success = success;
        }

        public bool Success
        {
            get;
            protected set;
        }
    }
}
