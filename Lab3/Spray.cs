using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    class Spray : Brush
    {
        public Spray(Color brushColor, int size)
           : base(brushColor, size)
        {
        }


        public override void Draw(Bitmap image, int x, int y)
        {
            Random r = new Random();
            for (int s = Size; s > 0; s--)
            {
                for (int i = 0; i <= 360; i++)
                {
                    int x0 = (int)(s * Math.Cos(i) + x);
                    int y0 = (int)(s * Math.Sin(i) + y);
                    if (r.NextDouble() <= 0.05)
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
}
