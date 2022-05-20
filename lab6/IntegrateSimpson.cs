using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
            if (N == 0 & N < 0)
            {
                throw new ArgumentException("Значение разбиения не должно быть меньше или равно нулю!");
            }
            double h = (x2 - x1) / N;
            double sum = 0;
            BlockingButton(false);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                Thread.Sleep(100);
                sum += (gV(x1 + h * i) + 4 * gV(x1 + h * (i + 0.5)) + gV(x1 + h * (i + 1))) * h / 6;
                RaiseStepEvent(x1 + i, gV(x1 + i), sum);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            int ThreadSum = ts.Milliseconds;
            ThreadOnFinishCount(ThreadSum);
            RaiseFinishEvent(sum);
            BlockingButton(true);
            return sum;

        }
        public override double Integrate( double x1, double x2, Equation equation, double N)
        {
            
                return Integrate(x1, x2, equation.GetValue, N);
           

        }
        void ThreadOnFinishCount(int ThreadSum)
        {
            if (ThreadCount != null)
            {
                ThreadEventArgs args = new ThreadEventArgs()
                {
                    CalcTime = ThreadSum
                };
                ThreadCount(this, args);
            }
        }
        void RaiseStepEvent(double x, double f, double sum)
        {
            if (OnStep != null)
            {
                IntegratorEventArgs args = new IntegratorEventArgs()
                {
                    X = x,
                    F = f,
                    Integr = sum
                };
                OnStep(this, args);
            }
        }
        void BlockingButton(bool sw)
        {
            ButtonEventArgs args = new ButtonEventArgs()
            {
                sw = sw
            };
            BlockButton(this, args);
        }
        void RaiseFinishEvent(double sum)
        {
            if (OnFinish != null)
            {
                IntegratorEventArgs args = new IntegratorEventArgs()
                {
                    Integr = sum
                };
                OnFinish(this, args);
            }
        }   



        public override string ToString()
        {
            return "Интегрирование Симсона";
        }
    }
}
