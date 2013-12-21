using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoundaryValue
{
    class TestTwoEquation : Equation
    {
        public TestTwoEquation()
        {
            f = new FunctionFStar2();
            k = new FunctionKStar2();
            q = new FunctionQStar2();
        }

        public override List<double> getValues(BoundaryValue boundaryValue, int numberOfIntervals)
        {
            double[] x = new double[numberOfIntervals + 1];
            double[] y = new double[numberOfIntervals + 1];

            double step = (boundaryValue.endX - boundaryValue.beginX) / numberOfIntervals;
            for (int i = 0; i <= numberOfIntervals; i++)
            {
                x[i] = boundaryValue.beginX + i * step;
                y[i] = 0;
            }

            List<double> res = new List<double>(y);
            return res;
        }
    }
}
