using System;
using CSLabWork2.Vehicle;

namespace CSLabWork2
{
    /**
     * Реализовать два интерфейса PassangersAuto(описать метод перевозки
     * пассажиров) и CargoAuto (описать метод перевозки груза).
     * Написать классы Truck, Sedan, Pickup реализующие эти интерфейсы
     */
    class A2Program
    {
        static void Main(string[] args)
        {
            CargoAuto cargoAuto = new Pickup();

            cargoAuto.transportCargo();

            PassangersAuto passangersAuto = new Sedan();

            passangersAuto.transportPassangers();

            Console.ReadKey();
        }
    }
}
