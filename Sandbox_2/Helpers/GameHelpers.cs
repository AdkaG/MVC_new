﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sandbox_2.Helpers
{
    public class GameHelpers//12,5,2
    {
        public int[,,] WinningObliqueCombo { get; set; } =
        {
            {
                {0,4},
                {1,3},
                {2,2},
                {3,1},
                {4,0}
             },
            {
                {0,5},
                {1,4},
                {2,3},
                {3,2},
                {4,1}
             },
            {
                {1,4},
                {2,3},
                {3,2},
                {4,1},
                {5,0}
             },
            {
                {1,5},
                {2,4},
                {3,3},
                {4,2},
                {5,1}
             },
            {
                {2,4},
                {3,3},
                {4,2},
                {5,1},
                {6,0}
             },
            {
                {2,5},
                {3,4},
                {4,3},
                {5,2},
                {6,1}
             },
            {
                {0,1},
                {1,2},
                {2,3},
                {3,4},
                {4,5}
             },
            {
                {0,0},
                {1,1},
                {2,2},
                {3,3},
                {4,4}
             },
            {
                {1,1},
                {2,2},
                {3,3},
                {4,4},
                {5,5}
             },
            {
                {1,0},
                {2,1},
                {3,2},
                {4,3},
                {5,4}
             },
             {
                {2,1},
                {3,2},
                {4,3},
                {5,4},
                {6,5}
             },
            {
                {2,0},
                {3,1},
                {4,2},
                {5,3},
                {6,4}
            }

    };
      
    }
}