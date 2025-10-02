using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class StudentController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReturnName(string Name)
        {
            return Content("Student Name" + Name);
        }
    }
}
