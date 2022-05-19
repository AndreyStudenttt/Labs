using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class SinEquation : Equation
    {
        public double a;
        public SinEquation(double a)
        {
            this.a = a;
        }
        public override double GetValue(double x)
        {
            return a * x * Math.Abs(Math.Sin(x));
        }
        public override string ToString()
        {
            return "Синусоидная функция";
        }
    }
}
