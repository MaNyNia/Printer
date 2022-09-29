using System;
using System.Collections.Generic;
using System.Text;

namespace Printers
{
   public abstract class Shape
    {
        public char Symbol { get; }
        public int XAxis { get; set; }
        public int YAxis { get; set; }
        public int Side { get; }
    }

}
