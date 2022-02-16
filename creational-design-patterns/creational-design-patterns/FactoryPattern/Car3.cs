using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creational_design_patterns.FactoryPattern
{
    public class Car3:IVehicle
    {
        public string GetCarType()
        {
            return "Car3";
        }

        public int GetNoOfSeats()
        {
            return 4;
        }

        public int GetPrice()
        {
            return 15000;
        }
    }
}
