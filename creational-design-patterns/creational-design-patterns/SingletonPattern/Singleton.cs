using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creational_design_patterns
{
    public sealed class Singleton
    {
        private static Singleton GetSingleton;
        private static int counter = 0;
        public static Singleton Instance;

        private static readonly Lazy<Singleton> Instancelock = new Lazy<Singleton>(() => new Singleton());
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public static Singleton GetInstance
        {
            get
            {
                return Instancelock.Value;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
