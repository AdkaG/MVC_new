using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Sandbox_2.Helpers;
using Sandbox_2.Models;

namespace Sandbox_2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult FiveInRowGame()
        {
            FiveInRow fiveInRowModel = new FiveInRow
            {
                FieldsList = new List<Field>
                {
                    new Field(new FieldCoordinates(6,0), '↓', "white",""),
                    new Field(new FieldCoordinates(6,1), '↓', "white",""),
                    new Field(new FieldCoordinates(6,2), '↓', "white",""),
                    new Field(new FieldCoordinates(6,3), '↓', "white",""),
                    new Field(new FieldCoordinates(6,4), '↓', "white",""),
                    new Field(new FieldCoordinates(6,5), '↓', "white",""),
                    new Field(new FieldCoordinates(6,6), '↓', "white","")
                    
                }
            };
            Session["ActiveGame"] = fiveInRowModel;
            return View(fiveInRowModel);
        }
        [HttpPost]
        public ActionResult FiveInRowGame(int? button)
        {
            var fiveInRowModel = (FiveInRow)Session["ActiveGame"];
            if (button == null || fiveInRowModel == null)
            {
                return FiveInRowGame();
            }

            //method
            fiveInRowModel.Insert(button.Value, 'x', "orange");
            return View(fiveInRowModel);
        }
    }
}