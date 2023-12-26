using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    internal class TwoOl
    {
        public double a, b;
        public TwoOl(double _a, double _b)
        {
            a = _a;
            b = _b;
        }
        public void Show()
        {
            Console.WriteLine(a + "+" + b + "i");
        }
        public static TwoOl operator *(TwoOl n1, TwoOl n2)
        {
            return new TwoOl(n1.a * n2.a - n1.b * n2.b, n1.a * n2.b + n1.b * n2.a);
        }

    }
}