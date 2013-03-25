using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Domain.Entities;


namespace EntityFramework
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
    }
}
