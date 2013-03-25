using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.EF.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private Context databaseContext;

        public Context Get()
        {
            return databaseContext ?? (databaseContext = new Context());
        }

        public override void DisposeCore()
        {
            if (databaseContext != null)
            {
                databaseContext.Dispose();
            }
        }
    }
}
