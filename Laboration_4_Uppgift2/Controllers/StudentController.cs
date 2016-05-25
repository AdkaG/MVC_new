using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboration_4_Uppgift2.Models;

namespace Laboration_4_Uppgift2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            Student student = new Student()
            {
                StudentId = 1,
                Name = "Jan",
                LastName = "Kowalski",
                Address = "Zdrojowa 23",
                Personnumber = "0205047777",
                Grades = new List<Grade>()
                {
                    new Grade()
                    {
                        CourseName = "HTML5",
                        TheGrade = "A+"
                    },
                    new Grade()
                    {
                        CourseName = "JavaScript",
                        TheGrade = "AB"
                    },
                    new Grade()
                    {
                        CourseName = "C# beautiful code",
                        TheGrade = "A"
                    }
                }
            };
            Session["Student"] = student;
            return View(student);
        }
    }
}