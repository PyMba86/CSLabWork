using System;

namespace CSLabWork4
{
    /**
     * Написать public static методы: int min(int, int), long min(long, long),
     * double min(double, double). Каждый метод должен возвращать минимальное 
     * из двух переданных в него чисел.
     */
    class A7Program
    {
        static int min(int a, int b)
        {
            return a < b ? a : b;
        }

        static long min(long a, long b)
        {
            return a < b ? a : b;
        }

        static double min(double a, double b)
        {
            return a < b ? a : b;
        }

        static void Main(string[] args)
        {

        }
    }
}
