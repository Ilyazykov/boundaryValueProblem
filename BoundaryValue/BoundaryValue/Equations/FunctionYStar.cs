using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoundaryValue
{
    class FunctionYStar : GetterListOfValues
    {
        public double ksi { get; private set; }

        public FunctionYStar(double ksi) 
        {
            this.ksi = ksi;
        }

        public double getValue(double x)
        {
            double lambda1 = Math.Sqrt(Math.Exp(ksi*ksi) * (ksi*ksi +1));
            double b1 = Math.Sin(ksi)/(ksi*ksi + 1);

            double lambda2 = ksi / Math.Sqrt(ksi + 1);
            double b2 = Math.Cos(ksi) / (ksi * ksi);

            if (x < ksi) return Math.Exp(lambda1 * x) + b1;
            else return Math.Exp(lambda2 * x) + b2;
        }

        public override List<double> getValues(BoundaryValue boundaryValue, int numberOfIntervals)
        {
            double[] x = new double[numberOfIntervals + 1];
            double[] y = new double[numberOfIntervals + 1];

            double step = (boundaryValue.endX - boundaryValue.beginX) / numberOfIntervals;
            for (int i = 0; i <= numberOfIntervals; i++)
            {
                x[i] = boundaryValue.beginX + i * step;
            }

            for (int i = 0; i <= numberOfIntervals; i++)
            {
                y[i] = getValue(x[i]);
            }

            List<double> res = new List<double>(y);
            return res;
        }
    }
}
