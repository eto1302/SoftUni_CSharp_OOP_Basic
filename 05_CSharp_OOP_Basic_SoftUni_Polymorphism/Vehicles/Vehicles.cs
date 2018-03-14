using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicles
{
    protected double fuelQuantity { get;  set; }
    protected double fuelConsumptionPerKm { get; set; }

    public Vehicles(double fuelQuantity, double fuelConsumptionPerKm)
    {
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumptionPerKm = fuelConsumptionPerKm;
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
        this.fuelQuantity += fuel;
    }
}
