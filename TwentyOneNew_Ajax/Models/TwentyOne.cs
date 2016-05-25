using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwentyOneNew_Ajax.Models
{
    public class TwentyOne
    {
        public string Player { get; set; }
        public int CurrentValue { get; set; }



        public int AddCurrentValue(int value)
        {
            CurrentValue += value;
            return CurrentValue;
        }
    }
}