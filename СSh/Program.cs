using System;

namespace СSh
{
    class Program
    {
        static void f (double x, out double y)
        {
            if ((x + 2) <= 1)
                y = x * x;
            else if (1 < (x + 2) && (x + 2) < 10)
                y = 1 / (x + 2);
            else
                y = x + 2;
        }

        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            double y;

            for (double i = a; i <= b; i += h)
            {
                f(i, out y);
                Console.WriteLine("f({0}) = {1}", i, y);
            }

            Console.ReadKey();
        }
    }
}
