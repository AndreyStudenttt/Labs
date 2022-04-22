using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    class QuadBrush : Brush
    {
        public QuadBrush(Color brushColor, int size)
            : base(brushColor, size)
        {
        }


        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; y0++)
            {
                for (int x0 = x - Size; x0 < x + Size; x0++)
                {
                    try
                    {
                        image.SetPixel(x0, y0, BrushColor);
                    }
                    catch { }

                }
            }
        }
    }
}
