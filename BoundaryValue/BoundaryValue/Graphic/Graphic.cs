using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoundaryValue
{
    class Graphic
    {
        public List<double> x;
        public List<double> y;

        public int numberOfIntervals { get; private set; }

        
        public Graphic(int numberOfIntervals)
        {
            this.numberOfIntervals = numberOfIntervals;
            x = new List<double>();
            y = new List<double>();
        }

        public void getFrom(GetterListOfValues getter, BoundaryValue boundaryValue)
        {
            double step = (boundaryValue.endX - boundaryValue.beginX) / numberOfIntervals;
            for (int i = 0; i <= numberOfIntervals; i++)
            {
                x.Add(boundaryValue.beginX + i * step);
            }

            y = getter.getValues(boundaryValue, numberOfIntervals);
        }
    }
}