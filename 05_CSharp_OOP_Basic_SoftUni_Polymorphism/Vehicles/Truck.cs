using System;
using System.Collections.Generic;
using System.Text;

class Truck : Vehicles
{
    public Truck(double fuelQuantity, double fuelConsumptionPerKm) : base(fuelQuantity, fuelConsumptionPerKm)
    {
        
    }

    public override void RefuelVehicle(double fuel)
    {
        base.RefuelVehicle(0.95*fuel);
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

