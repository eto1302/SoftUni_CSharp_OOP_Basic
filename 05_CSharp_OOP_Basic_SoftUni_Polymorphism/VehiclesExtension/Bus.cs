using System;
using System.Collections.Generic;
using System.Text;

class Bus : Vehicles
{
    public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {

    }

    public override string TravelDistance(double distance)
    {
        if ((distance * (this.fuelConsumptionPerKm + 1.4)) <= fuelQuantity)
        {
            fuelQuantity -= (distance * (this.fuelConsumptionPerKm + 1.4));
            return string.Format($"Bus travelled {distance} km");
        }

        return string.Format("Bus needs refueling");
    }

    public override void RefuelVehicle(double fuel)
    {
        base.RefuelVehicle(fuel);
    }

    public string DriveEmptyBus(double distance)
    {
        if ((distance * (this.fuelConsumptionPerKm)) <= fuelQuantity)
        {
            fuelQuantity -= (distance * (this.fuelConsumptionPerKm ));
            return string.Format($"Bus travelled {distance} km");
        }

        return string.Format("Bus needs refueling");
    }

    public override string ToString()
    {
        return string.Format($"Bus: {this.fuelQuantity:F2}");
    }
}
