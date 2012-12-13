using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.CommandProcessor.Command;
using TechEasy.Core.Common;

namespace TechEasy.CommandProcessor.Dispatcher
{
    public interface ICommandBus
    {
        ICommandResult Submit<TCommand>(TCommand command) where TCommand : ICommand;
        IEnumerable<ValidationResult> Validate<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
