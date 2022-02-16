using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creational_design_patterns.FactoryPattern
{
    class Car1 : IVehicle
    {
        public string GetCarType()
        {
            return "Car 1";
        }

        public int GetNoOfSeats()
        {
            return 6;
        }

        public int GetPrice()
        {
            return 20000;
        }

    }
}
