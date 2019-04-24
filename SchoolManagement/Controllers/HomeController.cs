using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class HomeController : Controller
    {
        SchoolManagementDBEntities ctx = new SchoolManagementDBEntities();
        // GET: Home
        public ActionResult IndexParent(int? parentID)
        {
            Parent parent = ctx.Parents.FirstOrDefault(x => x.ParentID == parentID);
             return View(parent);
            //if (parentID != null)
            //{

            //    Parent parent = ctx.Parents.FirstOrDefault(x => x.ParentID == parentID);
            //    return View(parent);
            //}
            //return View();
        }
        public ActionResult IndexAdmin()
        {
            return View();
        }
    }
}