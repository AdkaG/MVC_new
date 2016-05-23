using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboration_1.Models;

namespace Laboration_1.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EcUtbildning()
        {
            return View();
        }
        public ActionResult Ericsson()
        {
            return View();
        }
        public ActionResult Volvo(int? carModel)
        {
            if (carModel == 60)
            {
                return View("Volvo_S60");
            }
            else if (carModel == 70)
            {
                return View("Volvo_XC70");
            }
            else if (carModel == 90)
            {
                return View("Volvo_S90");
            }
            else return View();

        }

        public ActionResult ShowVolvoDecsription(VolvoCar car)
        {
            if (car.Model == "S 60")
            {
                return View("Volvo_S60");
            }
            else if (car.Model == "XC 70")
            {
                return View("Volvo_XC70");
            }
            else
            {
                return View("Volvo_S90");
            }
        }
    }
}