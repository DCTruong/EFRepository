using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Migrations;

namespace Infrastructure.EF.Infrastructure
{
    public class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Infrastructure.EF.SchoolContext";
        }
    }
}
