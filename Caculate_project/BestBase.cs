using System;

namespace Caculate_project
{
    private class BestBase
    {
        public static double Cal(String cal, double x, double y)
        {
            if (cal == "+") return x + y;
            else if (cal == "-") return x - y;
            else if (cal == "*") return x * y;
            else if (cal == "/") return x / y;
            else if (cal == "%") return x % y;
        }
        public static float Cal(String cal, float x, float y)
        {
            if (cal == "+") return x + y;
            else if (cal == "-") return x - y;
            else if (cal == "*") return x * y;
            else if (cal == "/") return x / y;
            else if (cal == "%") return x % y;
        }
        public static long Cal(String cal, long x, long y)
        {
            if (cal == "+") return x + y;
            else if (cal == "-") return x - y;
            else if (cal == "*") return x * y;
            else if (cal == "/") return x / y;
            else if (cal == "%") return x % y;
        }
    }
}