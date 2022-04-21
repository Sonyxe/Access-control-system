using Access_control_system.Models;
using System;

namespace Access_control_system
{
    public class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter person Id number");
                int personNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter door Id number");
                int doorNumber = Convert.ToInt32(Console.ReadLine());

                Event events = new Event();
                Console.WriteLine(events.Check( personNumber, doorNumber));

            }
        }
    }
}

