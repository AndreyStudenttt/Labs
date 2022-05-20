using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int RectangleArea (int a, int b)
        {
            if (a < 0 || b < 0) throw new ArgumentException();
            return a * b;
        }
    }
}
