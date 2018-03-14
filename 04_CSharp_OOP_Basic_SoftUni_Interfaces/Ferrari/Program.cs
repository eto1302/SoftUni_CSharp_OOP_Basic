using System;

namespace Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();
            Ferrari car = new Ferrari(driverName);
            car.PrintMessage();
        }
    }
}