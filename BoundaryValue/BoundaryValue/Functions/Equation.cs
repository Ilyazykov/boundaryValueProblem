using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoundaryValue
{
    class Equation
    {
        public FunctionF f { get; private set; }
        public FunctionK k { get; private set; }
        public FunctionQ q { get; private set; }

        public Equation(double ksi)
        {
            f = new FunctionF(ksi);
            k = new FunctionK(ksi);
            q = new FunctionQ(ksi);
        }
    }
}
