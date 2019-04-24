using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class StudentController : Controller
    {
        SchoolManagementDBEntities ctx = new SchoolManagementDBEntities();
        // GET: Student
        public ActionResult Index()
        {
            List<Student> stdList = ctx.Students.ToList();

            return View(stdList);
        }
        public ActionResult StudentScores()
        {
            return View();
        }
    }
}