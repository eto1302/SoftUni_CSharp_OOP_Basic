using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicles
{
    protected double fuelQuantity { get; set; }
    protected double fuelConsumptionPerKm { get; set; }
    protected double tankCapacity { get; set; }

    public Vehicles(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
    {
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumptionPerKm = fuelConsumptionPerKm;
        this.tankCapacity = tankCapacity;
        if (fuelQuantity > tankCapacity) this.fuelQuantity = 0;
    }

    public virtual string TravelDistance(double distance)
    {
        if (distance * this.fuelConsumptionPerKm <= fuelQuantity)
        {
            fuelQuantity -= distance * this.fuelConsumptionPerKm;
            return string.Format($"Vehicle travelled {distance} km");
        }

        return string.Format("Vehicle needs refueling");
    }

    public virtual void RefuelVehicle(double fuel)
    {
        if(fuel <= 0) Console.WriteLine("Fuel must be a positive number");
        else if(this.fuelQuantity + fuel <= this.tankCapacity)this.fuelQuantity += fuel;
        else Console.WriteLine($"Cannot fit {fuel} fuel in the tank");

    }
}
