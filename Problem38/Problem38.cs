using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem38
{
    public interface ICar
    {
        void Start();
        void Drive();
        void Stop();
    }

    public class Car : ICar
    {
        int fuel = 10;

        public void Start()
        {
            Console.WriteLine("\n The car has started.");
        }

        public void Drive()
        {
            fuel = fuel - 1;
        }
        public void Stop()
        {
            Console.WriteLine("\n The car has stopped.");
        }
    }
    class MyClass38
    {
        public void Problem38() { }
    }
}
