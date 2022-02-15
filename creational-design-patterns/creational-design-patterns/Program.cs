using creational_design_patterns;

namespace creationalDesignPattern{

    public class Program
    {
        static void Main(string[] args)
        {
            //parallel invocation of two methods.
            Parallel.Invoke(
                () => Print1stInvokation(),
                () => Print2ndInvokation()
                );
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