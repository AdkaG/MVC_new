using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI.WebControls;
using Laboration2_Uppgift1.Helpers;

namespace Laboration2_Uppgift1.Models

{
    public class TwentyOne
    {
        public List<GameField> GameFields { get; set; }
        public GameStatus ActiveGameStatus { get; set; }

        public void Plus(int value)
        {
            if (GameFields[2].Value <= 17)
            {
                if (value == 1 || value == 2)//play after player moved
                {
                    PlayerMoved(value);
                }
                else if (value == 3)//play after comp moved
                {
                    var valueForCompMove = RandomComputerMove();
                    ComputerMoved(valueForCompMove);
                }
            }
            else if (GameFields[2].Value == 18)
            {
                if (value == 1)//play after player moved
                {
                    PlayerMoved(value);
                }
                else if (value == 2)//show 21/21 after player moved
                {
                    PlayerGoneToTwenty(value);
                }
                else if (value == 3)
                {
                    var valueForCompMove = RandomComputerMove();
                    if (valueForCompMove == 1)//play after comp moved
                    {
                        ComputerMoved(valueForCompMove);
                    }
                    else if (valueForCompMove == 2)//show 21/21 after comp moved
                    {
                        ComputerGoneToTwenty(value);
                    }
                }
            }
            else if (GameFields[2].Value == 19)
            {
                if (value == 1)//show 21/21 after player moved
                {
                    PlayerGoneToTwenty(value);
                }
                else if (value == 2)//player win
                {
                    TheWinner();
                    ActiveGameStatus.TextOnScreen = "You win!!!";
                }
                else if (value == 3)//comp win
                {
                    TheWinner();
                    ActiveGameStatus.TextOnScreen = "Computer win!!!";
                }
            }
            else if (GameFields[2].Value == 20)
            {
                if (value == 1)
                {
                    TheWinner();
                    ActiveGameStatus.TextOnScreen = "You win!!!";
                }
                if (value == 3)
                {
                    TheWinner();
                    ActiveGameStatus.TextOnScreen = "Computer win!!!";
                }
            }
        }

        private void TheWinner()
        {
            GameFields[0].Value = 21;
            GameFields[1].Value = 21;
            GameFields[2].Value = 21;
            GameFields[0].Color = "";
            GameFields[1].Color = "";
            GameFields[1].Active = "disabled";
            GameFields[0].Active = "disabled";
            GameFields[2].Color = "pink";
            GameFields[GameFields.Count - 1].Active = "disabled";
        }

        private void ComputerGoneToTwenty(int value)
        {
            GameFields[0].Value = 21;
            GameFields[1].Value = 21;
            GameFields[2].Value += value;
            GameFields[1].Active = "";
            GameFields[0].Active = "";
            GameFields[0].Color = "hotpink";
            GameFields[1].Color = "hotpink";
            GameFields[GameFields.Count - 1].Active = "disabled";
            GameFields[GameFields.Count - 1].Color = "";
            ActiveGameStatus.TextOnScreen = "Your turn. Select number.";
        }

        private void PlayerGoneToTwenty(int value)
        {
            GameFields[0].Value = 21;
            GameFields[1].Value = 21;
            GameFields[2].Value += value;
            GameFields[1].Active = "disabled";
            GameFields[0].Active = "disabled";
            GameFields[0].Color = "";
            GameFields[1].Color = "";
            GameFields[GameFields.Count - 1].Active = "";
            GameFields[GameFields.Count - 1].Color = "hotpink";
            ActiveGameStatus.TextOnScreen = "Computer turn. Click the button.";
        }

        private void ComputerMoved(int valueForCompMove)
        {

            for (int i = 0; i < GameFields.Count - 1; i++)
            {
                GameFields[i].Value += valueForCompMove;
            }
            GameFields[0].Active = "";
            GameFields[1].Active = "";
            GameFields[0].Color = "hotpink";
            GameFields[1].Color = "hotpink";
            GameFields[GameFields.Count - 1].Active = "disabled";
            GameFields[GameFields.Count - 1].Color = "";
            ActiveGameStatus.TextOnScreen = "Your turn. Select number.";
        }

        private void PlayerMoved(int value)
        {
            for (int i = 0; i < GameFields.Count - 1; i++)
            {
                GameFields[i].Value += value;
            }
            GameFields[0].Active = "disabled";
            GameFields[1].Active = "disabled";
            GameFields[0].Color = "";
            GameFields[1].Color = "";
            GameFields[GameFields.Count - 1].Active = "";
            GameFields[GameFields.Count - 1].Color = "hotpink";
            ActiveGameStatus.TextOnScreen = "Computer turn. Click the button.";
        }

        private static int RandomComputerMove()
        {
            Thread.Sleep(500);
            Random rand = new Random();
            int valueForCompMove = rand.Next(1, 3);
            return valueForCompMove;
        }
    }
}
