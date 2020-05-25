using System;

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
            Pet cat = new Cat();
            Pet childCat = cat.getChild();

            Pet dog = new Dog();
            Pet childDog = dog.getChild();
        }
    }
}
