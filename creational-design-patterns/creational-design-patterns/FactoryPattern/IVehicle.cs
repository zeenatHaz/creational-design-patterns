using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creational_design_patterns.FactoryPattern
{
    public interface IVehicle
    {
        string GetCarType();
        int GetNoOfSeats();
        int GetPrice();
    }
}
