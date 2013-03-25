using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastructure.EF.Repository;
using Domain.Entities;

namespace Service
{
    public class StudentService : IStudentService
    {
        private IStudentRespository StudentRepository { get; set; }

        public StudentService(IStudentRespository studentRepository)
        {
            StudentRepository = studentRepository;
        }

        public void CreateStudent(Student student)
        {
            StudentRepository.Add(student);
            StudentRepository.Save();
        }
        public void Save()
        {
            StudentRepository.Save();
        }
    }
}
