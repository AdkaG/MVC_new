using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        
        public PartialViewResult GetCarCreate(int id)
        {
            Car car = new Car()
            {
                PersonId = id
            };
            return PartialView(viewName:"_GetCarCreate", model:car);
        }
    }
}