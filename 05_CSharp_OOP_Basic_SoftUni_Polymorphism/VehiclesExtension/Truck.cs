using System;
using System.Collections.Generic;
using System.Text;

class Truck : Vehicles
{
    public Truck(double fuelQuantity, double fuelConsumptionPerKm , double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {

    }

    public override void RefuelVehicle(double fuel)
    {
        if (fuel <= 0) Console.WriteLine("Fuel must be a positive number");
        else if (this.fuelQuantity + fuel*0.95 <= this.tankCapacity) this.fuelQuantity += fuel*0.95;
        else Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
    }

    public override string TravelDistance(double distance)
    {

        if ((distance * (this.fuelConsumptionPerKm + 1.6)) <= fuelQuantity)
        {
            fuelQuantity -= (distance * (this.fuelConsumptionPerKm + 1.6));
            return string.Format($"Truck travelled {distance} km");
        }

        return string.Format("Truck needs refueling");
    }

    public override string ToString()
    {
        return string.Format($"Truck: {this.fuelQuantity:F2}");
    }
}

