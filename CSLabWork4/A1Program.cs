using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLabWork4
{
    /**
     * Переопределить метод getName в классе Whale(Кит), чтобы программа выдавала:
     * Я не корова, Я – кит
     */
    class A1Program
    {
        static void Main(string[] args)
        {
            Cow cow = new Whale();

            Console.WriteLine(cow.getName());

            Console.ReadKey();
        }
    }
}
