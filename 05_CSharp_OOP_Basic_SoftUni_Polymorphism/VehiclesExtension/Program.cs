using System;

class Program
{
    static void Main(string[] args)
    {
        string carInput = Console.ReadLine();
        string[] carTokens = carInput.Split();
        Car car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3]));
        
        string truckInput = Console.ReadLine();
        string[] truckTokens = truckInput.Split();
        Truck truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(truckTokens[3]));

        string busInput = Console.ReadLine();
        string[] busTokens = busInput.Split();
        Bus bus = new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3]));

        int numberOfCommands = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfCommands; i++)
        {
            string commandInput = Console.ReadLine();
            string[] commandTokens = commandInput.Split();
            if (commandTokens[0] == "Drive")
            {
                if (commandTokens[1] == "Car")
                {
                    Console.WriteLine(car.TravelDistance(double.Parse(commandTokens[2])));

                }
                if (commandTokens[1] == "Truck")
                {
                    Console.WriteLine(truck.TravelDistance(double.Parse(commandTokens[2])));

                }
                if (commandTokens[1] == "Bus")
                {
                    Console.WriteLine(bus.TravelDistance(double.Parse(commandTokens[2])));
                }
            }
            if (commandTokens[0] == "Refuel")
            {
                if (commandTokens[1] == "Car")
                {
                    car.RefuelVehicle(double.Parse(commandTokens[2]));
                }
                if (commandTokens[1] == "Truck")
                {
                    truck.RefuelVehicle(double.Parse(commandTokens[2]));
                }
                if (commandTokens[1] == "Bus")
                {
                    bus.RefuelVehicle(double.Parse(commandTokens[2]));
                }
            }
            if(commandTokens[0] == "DriveEmpty" && commandTokens[1] == "Bus") Console.WriteLine(bus.DriveEmptyBus(double.Parse(commandTokens[2])));
        }
        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
        Console.WriteLine(bus.ToString());
    }
}
