using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor_view_and_help.Models;
namespace Razor_view_and_help.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>();
        // GET: Student
        public ActionResult Index()
        {
            return View( students);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            students.Add(s);
            return RedirectToAction("Index");

        }
    }
}