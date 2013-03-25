using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;
using Service;

namespace Web.Controllers
{
    public class StudentController : Controller
    {
        private Infrastructure.EF.Repository.IStudentRespository StudentRepository;
        private IStudentService StudentService { get; set; }

        public StudentController(Infrastructure.EF.Repository.IStudentRespository studentRepository, IStudentService studentService)
        {
            StudentRepository = studentRepository;
            StudentService = studentService;
        }

        public ActionResult Index()
        {
            IList<Student> lst = StudentRepository.GetAll().ToList();
            return View(lst);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                StudentService.CreateStudent(model);
                StudentService.Save();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", model);
        }

    }
}
