using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwentyOneAjax.Helpers;
using TwentyOneAjax.Models;

namespace TwentyOneAjax.Controllers
{
    public class TwentyOneController : Controller
    {
        // GET: TwentyOne
        public ActionResult TwentyOne()
        {
            var twentyOneModel = new TwentyOne
            {
                PresentValue = 0,
                ActiveGameStatus = new GameStatus()
            };
            Session["activeGame"] = twentyOneModel;
            return View(twentyOneModel);
        }

        [HttpPost]
        public PartialViewResult TwentyOne(int? field)
        {
            var twentyOneModel = (TwentyOne)Session["activeGame"];
            
            //logik
            twentyOneModel.Plus(field.Value);
            return PartialView(twentyOneModel);
        }
    }
}