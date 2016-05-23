using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration2_Uppgift2.Helpers
{
    public static class TicTacToeHelper
    {
        public static int[,] WinningCombos { get; set; } = {

            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {1, 4, 7},
            {2, 5, 8},
            {3, 6, 9},
            {1, 5, 9},
            {3, 5, 7}

        };
        private static List<int> GetFreeBoxes(List<BoxInfo> busyBoxes)
        {
            List<int> freeBoxes = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (BoxInfo p in busyBoxes)
            {
                int boxToRemove = p.BoxCoordinate;
                for (int j = 0; j < freeBoxes.Count; j++)
                {
                    if (freeBoxes[j] == boxToRemove)
                    {
                        freeBoxes.RemoveAt(j);
                    }
                }
            }
            return freeBoxes;
        }
        public static BoxInfo CompMove(List<BoxInfo> busyBoxes)
        {
            List<int> freeBoxes = GetFreeBoxes(busyBoxes); //alla fria boxes
            Random rnd = new Random();
            int computersMoveIndex = rnd.Next(freeBoxes.Count); //slumpa index, vilken box ska datorn markera
            int computerBox = freeBoxes[computersMoveIndex]; //markera den box
            BoxInfo computerMove = new BoxInfo(computerBox, 'o'); //new objekt
            return computerMove;
        }
    }
}