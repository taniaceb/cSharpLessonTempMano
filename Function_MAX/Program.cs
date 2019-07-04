using System;

namespace Function_MAX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max(4, 8, 6));
            Console.WriteLine(InRange(2, 5, 9));
       //Comment
        }

        static int Max(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;

        }
        static bool InRange (int a, int b, int c)
        {
            bool d;
            if ((a > b && a < c) || (a< b && a >c))
            {
                d= true;
            }
            else
            {
                d = false;
            }
            return d;
        }
    }
}
