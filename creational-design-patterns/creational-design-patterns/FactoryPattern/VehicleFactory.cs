using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creational_design_patterns.FactoryPattern
{
    public class VehicleFactory
    {

        public static IVehicle GetVehicleInfo(int cardTypeId)
        {
            IVehicle vehicle = null;
            switch (cardTypeId)
            {
                case 1:
                    {
                        vehicle = new Car1();
                        break;
                    }
                case 2:
                    {
                        vehicle= new Car2();
                        break;
                    }
                case 3:
                    {
                        vehicle = new Car3();
                        break;
                    }
                default:
                    {
                        //do nothing.
                        break;
                    }
            }

            return vehicle;
        }
    }
}
