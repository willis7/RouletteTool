﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteTool
{
    class Globals
    {
        #region Declarations
        public int gStrategyIdx = 0;
       #endregion

        #region Modifiers
        public int StrategyIndex
        {
            get { return gStrategyIdx; }
            set { gStrategyIdx = value; }
        }
        #endregion
    }
}
