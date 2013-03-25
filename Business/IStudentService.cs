using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastructure.EF.Repository;
using Domain.Entities;

namespace Service
{
    public interface IStudentService
    {
        void CreateStudent(Student student);
        void Save();
    }
}
