using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechEasy.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private TechEasyContext dataContext;

        public TechEasyContext Get()
        {
            return dataContext ?? (dataContext = new TechEasyContext(true));
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
