using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Snow : Brush
    {
        public Snow(Color brushColor, int size)
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
            int y1 = y + Size;
            for (int x1 = x - Size; x1 < x + Size; x1++)
            {
                if (y1 > y - Size)
                {
                    try
                    {
                        image.SetPixel(x1, y1, BrushColor);
                    }
                    catch { }

                    y1--;

                }

            }
            for (int x2 = x - Size; x2 < x + Size; x2++)
            {
                try
                {
                    image.SetPixel(x2, y, BrushColor);
                }
                catch { }

            }
            for (int y2 = y - Size; y2 < y + Size; y2++)
            {
                try
                {
                    image.SetPixel(x, y2, BrushColor);
                }
                catch { }

            }
        }

    }
}
