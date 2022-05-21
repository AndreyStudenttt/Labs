using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public delegate double GetValueDelegate(double x);

    public class ButtonEventArgs
    {
        public bool sw { get; set; }
    }
    public class IntegratorEventArgs
    {
        public double X { get; set; }
        public double F { get; set; }
        public double Integr { get; set; }
    }
    public class ThreadEventArgs
    {
        public int CalcTime { get; set; }
    }
    public abstract class Integrator
    {
        public delegate void IntStepDelegate(double x, double f, double integr);
        public delegate void IntFinishDelegate(double integr);
       
        public EventHandler<IntegratorEventArgs> OnStep;
        public EventHandler<IntegratorEventArgs> OnFinish;

        public delegate void ThreadEvent(int ThreadSum);
        public EventHandler<ThreadEventArgs> ThreadCount;

        public delegate void ButtonHandler(bool sw);
        public EventHandler<ButtonEventArgs> BlockButton;
        public abstract double Integrate(double x1, double x2,Equation equation, double N);
        public abstract double Integrate(double x1, double x2, GetValueDelegate GetValue, double N);
    }


}
