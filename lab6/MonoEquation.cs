using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class MonoEquation : Equation
    {
        public double a { get; set; }
        public double b { get; set; }
        public MonoEquation(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double GetValue(double x)
        {
            return a * x + b;
        }
        public override string ToString()
        {
            return "Линейная функция";
        }
    }
}
