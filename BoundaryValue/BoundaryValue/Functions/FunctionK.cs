using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoundaryValue
{
    class FunctionK : Function
    {
        double ksi;
        double numberOfStep;

        public FunctionK(double ksi, double numberOfStep = 100)
        {
            this.ksi = ksi;
            this.numberOfStep = numberOfStep;
        }

        public override double getValue(double x)
        {
            if (x < ksi) return Math.Exp(-x * x);
            else return x + 1;
        }

        public override double integrateFuncton(double from, double to)
        {
            throw new NotImplementedException();
        }

        public override double integrateDevidedOneIntoFunction(double from, double to)
        {
            if (to < ksi)
            {
                double dx = (to - from) / numberOfStep;

                double sum = 0;
                for (double x = from; x < to-dx; x += dx)
                {
                    sum += ( Math.Exp(x * x) + Math.Exp((x+1)*(x+1)) ) * dx / 2;
                }
                return sum;
            }
            else if (from > ksi)
            {
                return Math.Log((to+1)/(from+1), Math.E);
            }
            else 
            {
                double dx = (to - ksi) / numberOfStep;

                double sum = 0;
                for (double x = from; x <= ksi-dx; x += dx)
                {
                    sum += (Math.Exp(x * x) + Math.Exp((x + 1) * (x + 1))) * dx / 2;
                }

                sum += Math.Log((to + 1) / (ksi + 1), Math.E);

                return sum;
            }
        }
    }
}
