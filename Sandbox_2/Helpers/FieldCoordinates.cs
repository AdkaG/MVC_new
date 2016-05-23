using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sandbox_2.Helpers
{
    public class FieldCoordinates
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public FieldCoordinates(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }
    }
}