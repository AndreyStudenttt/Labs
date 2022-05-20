using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class IntegrateSimpson : Integrator
    {
        public IntegrateSimpson () { }
        public override double Integrate(double x1, double x2, GetValueDelegate gV, double N)
        {
            if (x1 >= x2)
            {
                throw new ArgumentException("Правая граница интегирования должны быть больше левой!");
            }
            double h = (x2 - x1) / N;
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += (gV(x1 + h * i) + 4 * gV(x1 + h * (i + 0.5)) + gV(x1 + h * (i + 1))) * h / 6;
            }
          
            return sum;

        }
        public override double Integrate( double x1, double x2, Equation equation, double N)
        {
            return Integrate( x1, x2, equation.GetValue, N);
        }
        public override string ToString()
        {
            return "Интегрирование Симсона";
        }
    }
}
