﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechEasy.CommandProcessor.Command
{
    public class ValidationHandlerNotFoundException:Exception
    {
        public ValidationHandlerNotFoundException(Type type)
            : base(string.Format("Validation handler not found for command type:{0}", type))
        { 
        
        }
    }
}
