using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using Laboration2_Uppgift2.Helpers;

namespace Laboration2_Uppgift2.Models
{
    public class TicTacToe
    {
        public List<BoxInfo> BoxList { get; set; } = new List<BoxInfo>();
        public List<string> Players { get; set; }
        public bool BordFull { get; set; } = false;
        public GameStatus ActiveGameStatus { get; set; } = new GameStatus();

        public string EfektGry { get; set; } = "Start the game! Select the field";

        public string GameOn(int coordinate, char symbol)
        {
            bool loop = true;
            do//max 2 gånger: 1 varv - granska allt efter spelare; 2 varv - granskar allt efter datorn; då datorn hade sista drag loop = false
            {
                BoxList.Add(new BoxInfo(coordinate, symbol)); //upptagna boxes, varje gång efter drag

                bool continueGame = WinningMove(symbol);

                if (continueGame == false) //nån vann
                {
                    ActiveGameStatus.Text = $"Congratulation (( {symbol} )). You win!!!";
                    return ActiveGameStatus.Status = "Winner";
                }

                if (BoxList.Count == 9) //alla boxes upptagna
                {
                    BordFull = true;
                    ActiveGameStatus.Text = "Game over. No winner.";
                    return ActiveGameStatus.Status = "No winner";
                }

                if (symbol == 'x')//sista drag gjorts av spelare, dator måste spela
                {
                    var compMove = TicTacToeHelper.CompMove(BoxList);
                    coordinate = compMove.BoxCoordinate;
                    symbol = compMove.Value;
                }
                else if (symbol == 'o')//sista drag gjorts av datorn, loop = false
                {
                    loop = false;
                }
            } while (loop);

            ActiveGameStatus.Text = "Next move, please...";//ingen vinnare, spelet sker
            return ActiveGameStatus.Status = "Active";
        }

        private bool WinningMove(char symbol)
        {
            var playerMoves = BoxList.Where(b => b.Value == symbol).Select(b => b.BoxCoordinate).ToList();//alla spelares/datorns drag
            
            for (int i = 0; i < 8; i++) //WinningCombos[i,j]
            {
                var hit = 0; //antal moves som stämmer med box i en WinningCombos
                for (int j = 0; j < 3; j++)
                {
                    foreach (int m in playerMoves)
                    {
                        var winningCombo = TicTacToeHelper.WinningCombos[i, j];
                        if (m != winningCombo) continue;
                        hit++;
                        break;
                    }
                }
                if (hit == 3)
                {
                    return false;//det finns vinnare - spelet stoppas
                }
            }
            return true; //ingen vinner - spelet fortsätter
        }
    }
}
