using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK5
{
    public class Triangle
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle()
        {
            SetParams(0d, 0d, 0d);
        }

        public double CalcPerimeter()
        {
            return A + B + C;
        }

        public void SetParams(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void SetParams(double a, double b, double c, bool doubleSize)
        {
            if (doubleSize)
            {            
                A = 2 * a;
                B = 2 * b;
                C = 2 * c;               
            }
            
        }
    }
}
