using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibls2
{
    public class SimpleLibrary
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }

        // число в степень
        public static int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }
    }
}
