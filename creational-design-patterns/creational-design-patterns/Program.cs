using creational_design_patterns;
using creational_design_patterns.FactoryPattern;

namespace creationalDesignPattern{

    public class Program
    {
        static void Main(string[] args)
        {
           // parallel invocation of two methods.
          //  singleton pattern.
            Parallel.Invoke(
                () => Print1stInvokation(),
                () => Print2ndInvokation()
                );
     
            //Factory Pattern.
            Console.WriteLine("Please enter the car Id:");
            int carId = Convert.ToInt32(Console.ReadLine());
            IVehicle vehicleDetails = VehicleFactory.GetVehicleInfo(carId);
            if (vehicleDetails != null)
            {
                Console.WriteLine("Type is :" + vehicleDetails.GetCarType() + Environment.NewLine
                    + "Count of Seats :" + vehicleDetails.GetNoOfSeats() + Environment.NewLine +
                    "Price :" + vehicleDetails.GetPrice());
            }
            else
            {
                Console.WriteLine("Invalid Car Id entered");
            }
            Console.ReadLine();
        }
        private static void Print1stInvokation()
        {
            Singleton obj = Singleton.GetInstance;
            obj.PrintDetails("From 1 call");
        }
        private static void Print2ndInvokation()
        {
            Singleton obj = Singleton.GetInstance;
            obj.PrintDetails("From 2 call");
        }
    }
    }