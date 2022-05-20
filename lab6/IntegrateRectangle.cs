using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class IntegrateRectangle : Integrator
    {
        public IntegrateRectangle() { }
        public override double Integrate(double x1, double x2, GetValueDelegate gV, double N)
        {
            if (x1 >= x2)
            {
                throw new ArgumentException("Правая граница интегирования должны быть больше левой!");
            }
            /* для интегирования разобъем исходный отрезок на 100 точек. 
             * Считаем значение функции в точке, умножаем на ширину интервала.
             * Площадь полученного прямоугольника приблизительно равна значению интеграла на этом отрезке
             * суммируем значения площадей, получаем значение интеграла на отрезке [X1;X2]*/
            //определяем ширину интервала:
            double h = (x2 - x1) / N;
            double sum = 0; //"накопитель" для значения интеграла
            for (int i = 0; i < N; i++)
            {
                sum = sum + gV(x1 + i * h) * h;
            }
            return sum;

        }
        public override double Integrate( double x1, double x2, Equation equation, double N)
        {
            return Integrate(x1, x2, equation.GetValue, N);
        }
        public override string ToString()
        {
            return "Интегрирование прямоугольником";
        }
    }
}
