using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSLabWork2.Animal;

namespace CSLabWork2
{
    /**
     * Создать абстрактный класс Pet с полями name, age, hungry(хочет есть)
     * и абстрактный метод voice(голос). Создать классы Snake, Dog, PatrolDog,
     * Cat, Fish и наследники класса Pet.
     * В каждом классе реализовать метод voice.
     */
    class A1Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Fish fish = new Fish();
            PatrolDog patrolDog = new PatrolDog();
            Snake snake = new Snake();

            cat.voice();
            dog.voice();
            fish.voice();
            patrolDog.voice();
            snake.voice();

            Console.ReadKey();
        }
    }
}
