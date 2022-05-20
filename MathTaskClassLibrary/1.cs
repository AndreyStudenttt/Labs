using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class First
    {
        public string Print(int N)
        {
            if (N < 1 || N > 26) throw new ArgumentException();
            StringBuilder summ = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                
                summ.Append((char)('A'+i));
            }
            return summ.ToString();
        }
    }
}
