using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Domain.Entities;
using System.Data.Entity.Migrations;
using Infrastructure.EF.Infrastructure;


namespace Infrastructure.EF
{
    public class Context : DbContext
    {
        public DbSet<Student> Student { get; set; }
        
        //public DbSet<Teacher> Teacher { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
        }
    }
    //public class SchoolContextInitializer : CreateDatabaseIfNotExists<SchoolContext>
    //{
    //    protected override void Seed(SchoolContext context)
    //    {
    //        Student student = new Student() { FirstName = "Truong", LastName = "Duong", Birthday = new DateTime(1985, 01, 12) };
    //        context.Student.Add(student);
    //    }
    //}
}
