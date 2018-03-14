using System;
using System.Collections.Generic;
using System.Text;

class Car : Vehicles
{
    public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {

    }

    public override string TravelDistance(double distance)
    {
        if ((distance * (this.fuelConsumptionPerKm + 0.9)) <= fuelQuantity)
        {
            fuelQuantity -= (distance * (this.fuelConsumptionPerKm + 0.9));
            return string.Format($"Car travelled {distance} km");
        }

        return string.Format("Car needs refueling");
    }

    public override void RefuelVehicle(double fuel)
    {
        base.RefuelVehicle(fuel);
    }

    public override string ToString()
    {
        return string.Format($"Car: {this.fuelQuantity:F2}");
    }
}
