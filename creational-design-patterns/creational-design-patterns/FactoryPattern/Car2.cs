using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creational_design_patterns.FactoryPattern
{
    public class Car2 : IVehicle
    {
        public string GetCarType()
        {
            return "Car2";
        }

        public int GetNoOfSeats()
        {
            return 7;
        }

        public int GetPrice()
        {
            return 30000;
        }
    }
}
