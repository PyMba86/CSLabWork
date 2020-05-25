using System;

namespace CSLabWork4
{
    class Dog : Cat
    {
        public override Pet getChild()
        {
            return new Dog();
        }
    }
}
