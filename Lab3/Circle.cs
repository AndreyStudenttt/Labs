using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Circle : Brush
    {
        public Circle(Color brushColor, int size)
           : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            for (int i = 0; i <= 360; i++)
            {
                int x0 = (int)(Size * Math.Cos(i) + x);
                int y0 = (int)(Size * Math.Sin(i) + y);
                try
                {
                    image.SetPixel(x0, y0, BrushColor);
                }
                catch { }

            }
        }
    }
}
