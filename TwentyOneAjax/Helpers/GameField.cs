using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwentyOneAjax.Helpers
{
    public class GameField
    {
        public int Value { get; set; }//obecna wartosc - wyswietlana
        public int PlusValue { get; set; }//1,2, 0 ...3
        
        public GameField(int value, int plusValue)
        {
            Value = value;
            PlusValue = plusValue;
           
        }
    }
}