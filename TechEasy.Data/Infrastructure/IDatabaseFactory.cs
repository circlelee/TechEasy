﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechEasy.Data.Infrastructure
{
    public interface IDatabaseFactory:IDisposable
    {
        TechEasyContext Get();
    }
}
