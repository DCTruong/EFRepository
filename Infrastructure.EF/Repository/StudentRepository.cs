using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using Infrastructure.EF.Infrastructure;

namespace Infrastructure.EF.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRespository
    {
        public StudentRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        { 
            
        }
    }
}
