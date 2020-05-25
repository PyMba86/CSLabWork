using System;

namespace CSLabWork4
{
    /**
    * Написать public static методы: int max(int, int), long max (long, long),
    * double max (double, double). Каждый метод должен возвращать максимальное
    * из двух переданных в него чисел.
    */
    class A8Program
    {
        static int max(int a, int b)
        {
            return a > b ? a : b;
        }

        static long max(long a, long b)
        {
            return a > b ? a : b;
        }

        static double max(double a, double b)
        {
            return a > b ? a : b;
        }
   
        static void Main(string[] args)
        {

        }
    }
}
