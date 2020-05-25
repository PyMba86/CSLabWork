using System;

namespace CSLabWork2.Vehicle
{
    class Pickup : PassangersAuto, CargoAuto
    {
        public void transportPassangers()
        {
            Console.WriteLine("Везу пассажиров");
        }

        public void transportCargo()
        {
            Console.WriteLine("Везу груз");
        }
    }
}
