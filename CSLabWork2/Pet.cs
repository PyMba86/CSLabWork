using System;

namespace CSLabWork2
{
    abstract class Pet
    {
        protected string name;
        protected int age;
        protected bool hungry;
        public abstract void voice();
    }
}
