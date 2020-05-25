using System;

namespace CSLabWork4
{
    /**
     * Переопределить метод getName в классе Whale(Кит), чтобы программа выдавала:
     * Я не корова, Я – кит
     */
    public class A1Program
    {
       public static void Main(string[] args)
        {
            Cow cow = new Whale();

            Console.WriteLine(cow.getName());

            Console.ReadKey();
        }
    }
}
