using creational_design_patterns;
using creational_design_patterns.FactoryPattern;
using static creational_design_patterns.FactoryPattern.VehicleFactory;

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
            IVehicle vehicle = new Car1Factory().CreateVehicle();
            if (vehicle != null)
            {
                //print the results.
                Console.WriteLine("car type :" + vehicle.GetCarType() + Environment.NewLine +
                    "count of seats :" + vehicle.GetNoOfSeats() + Environment.NewLine +
                    "price :" + vehicle.GetPrice());
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("==================================================");

            vehicle = new Car2Factory().CreateVehicle();
            if (vehicle != null)
            {
                //print the results.
                Console.WriteLine("car type :" + vehicle.GetCarType() + Environment.NewLine +
                    "count of seats :" + vehicle.GetNoOfSeats() + Environment.NewLine +
                    "price :" + vehicle.GetPrice());
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("==================================================");

            vehicle = new Car3Factory().CreateVehicle();
            if (vehicle != null)
            {
                //print the results.
                Console.WriteLine("car type :" + vehicle.GetCarType() + Environment.NewLine +
                    "count of seats :" + vehicle.GetNoOfSeats() + Environment.NewLine +
                    "price :" + vehicle.GetPrice());
            }
            else
            {
                Console.WriteLine("Invalid input");
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