using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLabWork4
{
    class Dog : Cat
    {
        public new Dog getChild()
        {
            return new Dog();
        }
    }
}
