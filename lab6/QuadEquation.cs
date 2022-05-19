using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    /// <summary>
    /// Класс, представляющий квадратное уравнение
    /// </summary>
    public class QuadEquation : Equation
    {
        public double a;
        public double b;
        public double c;

        public QuadEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double GetValue(double x)
        {
            return a * x * x + b * x + c;
        }
        public override string ToString()
        {
            return "Квадратичная функция";
        }
    }

}
