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
    }

    public class Car : ICar
    {
        int fuel = 10;

        public void Start()
        {
            Console.WriteLine("\n The car has started.\n");
        }

        public int Drive()
        {
            if(fuel <= 0)
            {
                Console.WriteLine($"\n You have {fuel} gallons fuel.\n");
                return fuel;
            }
            else
            {
                Console.WriteLine($"\n You have {fuel} gallons fuel.\n");
                return fuel = fuel - 1;
            }
        }
        public void Stop()
        {
            Console.WriteLine("\n The car has stopped.\n");
        }
    }
    class MyClass39
    {
        public void Problem39()
        {
            bool running = false;
            bool stopped = true;
            bool empty = false;

            Car car = new Car();
            
            Console.WriteLine("\n Greetings user, what would you like to do?");
            Console.WriteLine(" (Choices are 'start' 'drive' 'stop')");
            string input = Console.ReadLine().ToLower();

            while (input != null && empty == false && stopped == true)
            {
                if(input == "start" && stopped == true && running == false)
                {
                    car.Start();
                    running = true; stopped = false;
                }
                else if (input == "drive" && running == true)
                {
                    car.Drive();
                    stopped = false;
                }
                else if (input == "stop" && running == true && stopped == false)
                {
                    car.Stop();
                    stopped = true;
                }
                else
                {
                    //Console.WriteLine(" (Choices are 'start' 'drive' 'stop')\n");
                    //input = Console.ReadLine( ).ToLower();
                Console.WriteLine($"\n Car already running, please choose again.\n");
                Console.WriteLine(" (Choices are 'start' 'drive' 'stop')");
                input = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
