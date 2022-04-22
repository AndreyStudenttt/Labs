using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Erase : Brush
    {
        public Erase(Color brushColor, int size)
            : base(brushColor, size)
        {
           
            
        }
        Form1 form1 = new Form1();
        
        public override void Draw(Bitmap image, int x, int y)
        {
            Color erase = form1.DefaultColor;

            for (int y0 = y - Size; y0 < y + Size; y0++)
            {
                for (int x0 = x - Size; x0 < x + Size; x0++)
                {
                    image.SetPixel(x0, y0, erase);
                }
            }
        }
    }
}
