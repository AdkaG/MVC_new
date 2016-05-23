using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sandbox_2.Helpers;

namespace Sandbox_2.Models
{
    public class FiveInRow
    {
        public List<Field> FieldsList { get; set; } = new List<Field>();
        public bool FullBoard { get; set; } = false;
        public GameStatus ActiveGameStatus { get; set; } = new GameStatus();


        public void Insert(int insertIndex, char character, string color)
        {
            AddMove(insertIndex, character, color);
            bool loop = true;
            do
            {
                //if() jesli ktos ma 5 - wylacz wszystko, text, break; - metoda else...
                var allBusyFields = FieldsList.Count;
                if (WinningMove(character))
                {
                    ActiveGameStatus.Status = "Winner";
                    ActiveGameStatus.TextOnScreen = $"Congratulation (( {character} )). You win!!!";
                    break;
                }
                if (allBusyFields == 49)
                {
                    FullBoard = true;
                    ActiveGameStatus.Status = "No winner";
                    ActiveGameStatus.TextOnScreen = "Game over. No winner.";
                    break;
                }
                if (character == 'x')//datorn måste spela
                {
                    var compIndex = RandomFromFreeInserts();
                    AddMove(compIndex, 'o', "blue");
                    character = 'o';
                }
                else if (character == 'o')
                {
                    ActiveGameStatus.Status = "Active";
                    ActiveGameStatus.TextOnScreen = "Next move, please...";
                    loop = false;
                }

            } while (loop);

        }

        private bool WinningMove(char character)
        {
            List<Field> allPlayerFields = FieldsList.Where(f => f.FieldValue == character).ToList();//all fields from one player
            if (allPlayerFields.Count >= 5)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var playerCombo =
                            allPlayerFields.Where(
                                f =>
                                    f.FieldCoordinates.XCoordinate == i && f.FieldCoordinates.YCoordinate >= j &&
                                    f.FieldCoordinates.YCoordinate <= j + 4).ToList();
                        if (playerCombo.Count >= 5)
                        {
                            foreach (var item in FieldsList)
                            {
                                item.Activity = "disabled";
                            }
                            return true;
                        }
                    }
                }
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        var playerCombo =
                            allPlayerFields.Where(
                                f =>
                                    f.FieldCoordinates.YCoordinate == i && f.FieldCoordinates.XCoordinate >= j &&
                                    f.FieldCoordinates.XCoordinate <= j + 4).ToList();
                        if (playerCombo.Count >= 5)
                        {
                            foreach (var item in FieldsList)
                            {
                                item.Activity = "disabled";
                            }
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private int RandomFromFreeInserts()
        {
            List<int> freeIndexes = new List<int>();
            List<Field> freeFields =
                FieldsList.Where(f => f.FieldCoordinates.XCoordinate == 6 && f.Activity == "").ToList();
            foreach (var item in freeFields)
            {
                freeIndexes.Add(item.FieldCoordinates.YCoordinate);
            }

            Random rand = new Random();
            int index = rand.Next(0, freeIndexes.Count - 1);
            var compIndex = freeIndexes[index];
            return compIndex;
        }

        private Field AddMove(int insertIndex, char character, string color)
        {
            var insertField =
                FieldsList.FirstOrDefault(
                    f => f.FieldCoordinates.XCoordinate == 6 && f.FieldCoordinates.YCoordinate == insertIndex);
            List<Field> fieldsInColumn = new List<Field>();
            for (int i = 0; i < 6; i++)
            {
                var busyField =
                    FieldsList.FirstOrDefault(
                        f => f.FieldCoordinates.XCoordinate == i && f.FieldCoordinates.YCoordinate == insertIndex);
                if (busyField != null)
                {
                    fieldsInColumn.Add(busyField);
                }
            }
            var x = fieldsInColumn.Count;
            Field newField = new Field(new FieldCoordinates(x, insertIndex), character, color, "");
            FieldsList.Add(newField);
            if (x == 5)
            {
                insertField.FieldValue = '-';
                insertField.Activity = "disabled";
                insertField.Color = "black";
            }
            return newField;
        }


    }
}

