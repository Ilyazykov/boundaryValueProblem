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
    }
}
