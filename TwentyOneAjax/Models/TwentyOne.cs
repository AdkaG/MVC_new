using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using TwentyOneAjax.Helpers;

namespace TwentyOneAjax.Models
{
    public class TwentyOne
    {
        public int PresentValue { get; set; } = 0;
        public GameStatus ActiveGameStatus { get; set; }

        public void Plus(int value)
        {
            if (PresentValue <= 17)
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
            else if (PresentValue == 18)
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
            else if (PresentValue == 19)
            {
                if (value == 1)//show 21/21 after player moved
                {
                    PlayerGoneToTwenty(value);
                }
                else if (value == 2)//player win
                {
                    PresentValue = 21;
                    ActiveGameStatus.TextOnScreen = "You win!!!";
                }
                else if (value == 3)//comp win
                {
                    PresentValue = 21;
                    ActiveGameStatus.TextOnScreen = "Computer win!!!";
                }
            }
            else if (PresentValue == 20)
            {
                if (value == 1)
                {
                    PresentValue = 21;
                    ActiveGameStatus.TextOnScreen = "You win!!!";
                }
                if (value == 3)
                {
                    PresentValue = 21;
                    ActiveGameStatus.TextOnScreen = "Computer win!!!";
                }
            }
        }

        private void ComputerGoneToTwenty(int value)
        {
            PresentValue += value;
            ActiveGameStatus.TextOnScreen = "Your turn. Select number.";
        }

        private void PlayerGoneToTwenty(int value)
        {
           
            PresentValue += value;
            ActiveGameStatus.TextOnScreen = "Computer turn. Click the button.";
        }

        private void ComputerMoved(int valueForCompMove)
        {
            PresentValue += valueForCompMove;
           ActiveGameStatus.TextOnScreen = "Your turn. Select number.";
        }

        private void PlayerMoved(int value)
        {
           
                PresentValue += value;
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