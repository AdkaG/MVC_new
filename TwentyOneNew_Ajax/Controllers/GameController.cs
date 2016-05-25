using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwentyOneNew_Ajax.Models;

namespace TwentyOneNew_Ajax.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult GetValue()
        {
            TwentyOne game = new TwentyOne()
            {
                Player = "User",
                CurrentValue = 0
            };
            Session["game"] = game;
            return View(game);
        }

       public PartialViewResult GetValue(int buttonValue)
        {
            var game =((TwentyOne)Session["game"]);
            game.AddCurrentValue(buttonValue);
            return PartialView(game);
        }


    }
}