using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboration2_Uppgift2.Helpers;
using Laboration2_Uppgift2.Models;

namespace Laboration2_Uppgift2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult TicTacToe()
        {
            var ticTacToeModel = new TicTacToe();
            //{
            //    BoxList = new List<BoxInfo>
            //    {
            //        new BoxInfo(1, 'x'),
            //        new BoxInfo(2, 'o'),
            //        new BoxInfo(3, 'x'),
            //        new BoxInfo(7, 'o')
            //    },
            //    Players = new List<string> {"Adriana", "Erik"}
            //};

            Session["tictactoeGameModel"] = ticTacToeModel;
            return View(ticTacToeModel);
        }

        [HttpPost]
        public ActionResult TicTacToe(int? button)
        {
            var ticTacToeModel = (TicTacToe)Session["tictactoeGameModel"];
            if (button == null || ticTacToeModel == null)
            {
                return TicTacToe();

            }
            ticTacToeModel.GameOn(button.Value, 'x');
            return View(ticTacToeModel);
        }
    }
}