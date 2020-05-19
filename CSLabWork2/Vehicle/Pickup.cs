using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
