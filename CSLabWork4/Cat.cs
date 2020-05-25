using System;

namespace CSLabWork4
{
    class Cat: Pet
    {
        public override Pet getChild()
        {
            return new Cat();
        }
    }
}
