using System;

namespace CSLabWork4
{
    /**
     * Написать два метода: print(int) и print(Integer).
     * Написать такой код в методе main, чтобы вызвались они оба
     */
    class A5Program
    {
        static void print(int a)
        {
           
        }

        // Int32 является синонимом int
        static void print(Int64 a)
        {
           
        }

        static void Main(string[] args)
        {
            print(10);
            print(new Int64());
        }
    }
}
