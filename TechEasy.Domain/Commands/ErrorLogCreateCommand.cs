using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEasy.CommandProcessor.Command;
using TechEasy.Model;

namespace TechEasy.Domain.Commands
{
    public class ErrorLogCreateCommand:ICommand
    {
        public SA_ErrorLog model;
        public ErrorLogCreateCommand()
        { 
            
        }
    }
}
