using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration2_Uppgift1.Helpers
{
    public class GameField
    {
        public int Value { get; set; }//obecna wartosc - wyswietlana
        public int PlusValue { get; set; }//1,2, 0 ...3
        public string Active { get; set; }//disabled for third button
        public string Color { get; set; }

        public GameField(int value, int plusValue, string active, string color)
        {
            Value = value;
            PlusValue = plusValue;
            Active = active;
            Color = color;
        }
    }
}