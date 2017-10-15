using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem39
{
    public interface ICar
    {
        void Start();
        int Drive();
        void Stop();
        //void Empty();
        //bool Running { get; }
    }

    class Car : ICar
    {
        private bool running = false;
        int fuel = 10;

        public void Start()
        {
            if (fuel > 0)
            {
                if (running == false)
                {
                    Console.WriteLine("\n The car has started.\n");
                    running = true;
                }
                else
                {
                    Console.WriteLine($"\n Car already running, please choose again.\n");
                }
            }
            else
            {
                Console.WriteLine("\n You are out of fuel, vehicle will not start.");
                running = false;
            }
        }

        public int Drive()
        {
            if(fuel > 0)
            {
                if(running == true)
                {
                    fuel = fuel - 1;
                    Console.WriteLine($"\n Now driving. You have {fuel} gallons of fuel remaining.\n");
                    return fuel;
                }
                else
                {
                    Console.WriteLine($"\n You must first start the car before you can drive.\n");
                    return fuel;
                }
            }
            else
            {
                Console.WriteLine("\n You are out of fuel, vehicle will not start.");
                return fuel;
            }
        }
        public void Stop()
        {
            if(running == true)
            {
                Console.WriteLine("\n The car has stopped.\n");
                running = false;
            }
            else
            {
                Console.WriteLine("\n Car was never started. \n");
            }
        }


    }
    class MyClass39
    {
        public void Problem39()
        {            
            Car car = new Car();
            
            Console.WriteLine("\n Greetings user, what would you like to do?");
            Console.WriteLine(" (Choices are 'start' 'drive' 'stop')");
            string input = Console.ReadLine().ToLower();

            while (input != null )
            {
                if(input == "start")
                {
                    car.Start();
                }
                else if (input == "drive")
                {
                    car.Drive();                   
                }
                else if (input == "stop")
                {
                    car.Stop();
                }
                else
                {
                    Console.WriteLine("\n Please enter a vaild command.\n");
                }
                Console.WriteLine("\n What would you like to do? (Choices are 'start' 'drive' 'stop')");
                input = Console.ReadLine().ToLower();
            }            
        }
    }
}
