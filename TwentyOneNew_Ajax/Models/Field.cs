using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwentyOneNew_Ajax.Models
{
    public class Field
    {
        public int Value { get; set; }

        public int AddValue(int value)
        {
            Value += value;
            return Value;
        }
    }
}