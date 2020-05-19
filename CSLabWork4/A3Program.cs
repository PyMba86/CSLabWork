using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLabWork4
{
    /**
     * Создать два класса Cat(кот) и Dog(собака), класс Dog(собака) происходит
     * от Cat(кот). Определить метод getChild в классах Cat(кот) и Dog(собака),
     * чтобы кот порождал кота, а собака – собаку.
     */
    class A3Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Cat childCat = cat.getChild();

            Dog dog = new Dog();
            Dog childDog = dog.getChild();
        }
    }
}
