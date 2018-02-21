using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


public class Car
{
    public string model;
    public  decimal fuelAmount;
    public  decimal fuelConsumption;
    public  int distanceTravelled = 0;

    private string Model
    {
        get { return model; }
        set { model = value; }
    }
    private decimal FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }
    private decimal FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }
    private int DistanceTravelled
    {
        get { return distanceTravelled; }
        set { distanceTravelled = value; }
    }

    public Car(string newModel, decimal newFuelAmount, decimal newFuelConsumption, int newDistanceTravelled)
    {
        model = newModel;
        fuelAmount = newFuelAmount;
        fuelConsumption = newFuelConsumption;
        distanceTravelled = newDistanceTravelled;
    }
}

