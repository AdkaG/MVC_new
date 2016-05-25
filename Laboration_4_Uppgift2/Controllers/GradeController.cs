using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboration_4_Uppgift2.Models;

namespace Laboration_4_Uppgift2.Controllers
{
    public class GradeController : Controller
    {
        // GET: Grade
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GradesForStudent(int id)
        {
            List<Grade> grades = ((Student)Session["Student"]).Grades;
            return PartialView(grades);
        }
        public PartialViewResult Create(int id)
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Grade model)
        {
            ((Student)Session["Student"]).Grades.Add(model);
            return RedirectToAction("GradesForStudent", routeValues: new {id = 2});
        }
    }
}