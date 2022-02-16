using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creational_design_patterns.FactoryPattern
{
    public class VehicleFactory
    {


        public abstract class VehicheFactory
        {
            protected abstract IVehicle GetVehicleDetails();
            public IVehicle CreateVehicle()
            {
                return this.GetVehicleDetails();
            }
        }

        public class Car1Factory : VehicheFactory
        {
            protected override IVehicle GetVehicleDetails()
            {
                IVehicle car = new Car1();
                return car;
            }

            

        }


        public class Car2Factory : VehicheFactory
        {
            protected override IVehicle GetVehicleDetails()
            {
                IVehicle car = new Car2();
                return car;
            }



        }
        public class Car3Factory : VehicheFactory
        {
            protected override IVehicle GetVehicleDetails()
            {
                IVehicle car = new Car3();
                return car;
            }



        }
    }
}
