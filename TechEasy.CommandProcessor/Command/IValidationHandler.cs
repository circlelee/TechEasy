using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.Core.Common;

namespace TechEasy.CommandProcessor.Command
{
    public interface IValidationHandler<in TCommand> where TCommand:ICommand
    {
        IEnumerable<ValidationResult> Validate(TCommand command);
    }
}
