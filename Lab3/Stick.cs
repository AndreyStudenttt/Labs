using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    class Stick : Brush
    {
        public Stick(Color brushColor, int size)
            : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            int y0 = y - Size;
            for (int x0 = x - Size; x0 < x + Size; x0++)
            {
                if (y0 < y + Size)
                {
                    try
                    {
                        image.SetPixel(x0, y0, BrushColor);
                    }
                    catch { }

                    y0++;

                }

            }
        }
    }
}
