using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;

namespace Sandbox_2.Helpers
{
    public class Field
    {
        public FieldCoordinates FieldCoordinates { get; set; }
        public char FieldValue { get; set; }
        public string Color { get; set; }
        public string Activity { get; set; }

        public Field(FieldCoordinates coordinates, char value, string color, string active)
        {
            FieldCoordinates = coordinates;
            FieldValue = value;
            Color = color;
            Activity = active;
        }
    }
}