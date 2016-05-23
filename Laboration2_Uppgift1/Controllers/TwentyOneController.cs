using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboration2_Uppgift1.Helpers;
using Laboration2_Uppgift1.Models;
using Button = System.Web.UI.WebControls.Button;

namespace Laboration2_Uppgift1.Controllers
{
    public class TwentyOneController : Controller
    {
        // GET: TwentyOne
        public ActionResult TwentyOne()
        {
            var twentyOneModel = new TwentyOne
            {
                GameFields = new List<GameField>
                {
                    new GameField(1, 1,"", "hotpink"),
                    new GameField(2, 2,"", "hotpink"),
                    new GameField(0, 0,"disabled", ""),
                    new GameField(0, 3,"disabled", "")
                },
                ActiveGameStatus = new GameStatus()
            };
            Session["activeGame"] = twentyOneModel;
            return View(twentyOneModel);
        }

        [HttpPost]
        public ActionResult TwentyOne(int? field)
        {
            var twentyOneModel = (TwentyOne)Session["activeGame"];
            if (field == null || twentyOneModel == null)
            {
                return TwentyOne();
            }
            //logik
            twentyOneModel.Plus(field.Value);
            return View(twentyOneModel);
        }
    }
}