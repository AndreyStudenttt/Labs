using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public delegate double GetValueDelegate(double x);
    public abstract class Integrator
    {
       

        public abstract double Integrate(double x1, double x2,Equation equation, double N);
        public abstract double Integrate(double x1, double x2, GetValueDelegate GetValue, double N);
    }


}
