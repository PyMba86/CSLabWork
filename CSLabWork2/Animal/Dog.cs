using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLabWork2.Animal
{
    class Dog : Pet
    {
        public override void voice()
        {
            Console.WriteLine("Собака");
        }
    }
}
