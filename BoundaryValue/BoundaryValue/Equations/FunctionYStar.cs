using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoundaryValue
{
    class FunctionYStar : GetterListOfValues
    {
        public double ksi { get; private set; }

        private double c11, c12, c21, c22;
        private double a1, a2, b1, b2;

        public FunctionYStar(double ksi) 
        {
            this.ksi = ksi;

            getConstants();
        }

        private void getConstants()
        {
            double k1 = Math.Exp(-ksi * ksi);
            double k2 = ksi + 1;

            double q1 = ksi * ksi + 1;
            double q2 = ksi * ksi;

            double f1 = Math.Sin(ksi);
            double f2 = Math.Cos(ksi);

            a1 = q1 / k1;
            a2 = q2 / k2;

            b1 = f1 / q1;
            b2 = f2 / q2;

            double c21t1 = Math.Exp(-a1 * ksi) - Math.Exp(a1 * ksi);
            double c22t1 = Math.Exp(-2 * a2) * Math.Exp(a2 * ksi) - Math.Exp(-a2 * ksi);
            double t1 = Math.Exp(a2 * (ksi - 1)) * (1 - b2) + b2 - b1 + b1 * Math.Exp(a1 * ksi);

            double c21t2 = q1 * (Math.Exp(a1 * ksi) + Math.Exp(-a1 * ksi));
            double c22t2 = - q2 * (Math.Exp(a2 * (ksi - 2)) + Math.Exp(-a2 * ksi));
            double t2 = Math.Exp(a2 * (ksi - 1)) * (f2 - q2) - f1 * Math.Exp(a1 * ksi);

            c21 = (t1 * c22t2 - t2 * c22t1) / (c21t1 * c22t2 - c21t2 * c22t1);
            c22 = (c21t1 * t2 - c21t2 * t1) / (c21t1 * c22t2 - c21t2 * c22t1);

            c11 = - b1 - c21;
            c12 = (1 - b2 - c22 * Math.Exp(-a2)) * Math.Exp(-a2);
        }

        public double getValue(double x)
        {
            if (x < ksi)
            {
                return c11 * Math.Exp(a1 * x) + c21 * Math.Exp(-a1 * x) + b1;
            }
            else
            {
                return c12 * Math.Exp(a2 * x) + c22 * Math.Exp(-a2 * x) + b2;
            }
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
