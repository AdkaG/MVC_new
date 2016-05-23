using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Laboration2_Uppgift2.Helpers
{
    public struct BoxInfo
    {
        public int BoxCoordinate { get; private set; }
        public char Value { get; private set; }

        public BoxInfo(int box, char value)
        {
            //TODO: kontrolera value
            BoxCoordinate = box;
            Value = value;
        }
    }
}