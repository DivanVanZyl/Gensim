using System;
using System.Collections.Generic;
using System.Text;

namespace Gensim.Helpers
{
    public static class Math
    {
        public static int Fibonacci(int n)
        {
            if((n == 0) || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
