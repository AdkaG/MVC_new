using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class TwentyOneController : Controller
    {
        // GET: TwentyOne
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Play()
        {
            Game.CurentValue = 0;
            Game.Message = "Play";
            return View();
        }

        //public int AddValue(int buttonValue)
        //{
        //    Game.GetCurrentValue(buttonValue);
        //    return Game.CurentValue;
        //}
        public PartialViewResult AddValue(int buttonValue)
        {
            var game = Game.GetCurrentValue(buttonValue);
            return PartialView("_GamePV", model: game);
        }
    }
}