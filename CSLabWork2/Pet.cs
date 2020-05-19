using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
