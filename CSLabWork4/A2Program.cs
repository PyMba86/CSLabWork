using System;

namespace CSLabWork4
{
    /**
     * Написать метод, который определяет, объект какого класса ему передали,
     * и выводит на экран одну из надписей: Кошка, Собака, Птица, Лампа
     */
    class A2Program
    {
        static void printType(Object o)
        {
            if (o is Cat)
            {
                Console.WriteLine("Кошка");
            }
            else if (o is Dog)
            {
                Console.WriteLine("Собака");
            }
            else if (o is Bird)
            {
                Console.WriteLine("Птица");
            }
            else if (o is Lamp)
            {
                Console.WriteLine("Лампа");
            }
        }

        static void Main(string[] args)
        {
            printType(new Cat());
            printType(new Bird());
            printType(new Lamp());

            Console.ReadKey();
        }
    }
}