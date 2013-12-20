using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoundaryValue
{
    class Graphic
    {
        public double[] x;
        public double[] y;

        public int numberOfIntervals { get; private set; }

        
        public Graphic(int numberOfIntervals)
        {
            this.numberOfIntervals = numberOfIntervals;
            x = new double[numberOfIntervals + 1];
            y = new double[numberOfIntervals + 1];
        }

        public void getFrom(Equation equation, BoundaryValue boundaryValue)
        {
            double[] a = new double[numberOfIntervals + 1];
            double[] d = new double[numberOfIntervals + 1];
            double[] f = new double[numberOfIntervals + 1];

            double[] alpha = new double[numberOfIntervals + 1];
            double[] beta = new double[numberOfIntervals + 1];

            double step = (boundaryValue.endX - boundaryValue.beginX) / numberOfIntervals;
            for (int i = 0; i <= numberOfIntervals; i++)
            {
                x[i] = boundaryValue.beginX + i * step;
            }

            for (int i = 1; i < numberOfIntervals; i++)
            {

                d[i] = (equation.q.integrateFuncton(x[i] + step / 2, x[i] - step / 2)) / step;
                f[i] = (equation.f.integrateFuncton(x[i] + step / 2, x[i] - step / 2)) / step;
                a[i] = step / (equation.k.integrateDevidedOneIntoFunction(x[i - 1], x[i]));
            }
            a[numberOfIntervals] = step / (equation.k.integrateDevidedOneIntoFunction(x[numberOfIntervals - 1], x[numberOfIntervals]));

            y[0] = boundaryValue.beginY;
            y[numberOfIntervals] = boundaryValue.endY;

            for (int i = 2; i <= numberOfIntervals; i++)
            {
                alpha[i] = (-a[i]) / (-a[i] - a[i - 1] - d[i - 1] * step * step + alpha[i - 1] * a[i - 1]);
                beta[i] = (-f[i - 1] * step * step - a[i - 1] * beta[i - 1]) / (-a[i] - a[i - 1] - d[i - 1] * step * step + alpha[i - 1] * a[i - 1]);
            }

            for (int i = numberOfIntervals - 1; i > 0; i--)
            {
                y[i] = alpha[i + 1] * y[i + 1] + beta[i + 1];
            }
        }

    }
}