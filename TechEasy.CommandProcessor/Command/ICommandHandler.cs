using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechEasy.CommandProcessor.Command
{
    public interface ICommandHandler<in TCommand> where TCommand:ICommand
    {
        ICommandResult Execute(TCommand command);
    }
}
