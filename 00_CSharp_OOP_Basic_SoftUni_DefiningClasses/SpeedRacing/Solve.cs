using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Text;

    class Solve
    {
    List<Car> cars = new List<Car>();

        public void AddCars(Car member)
        {
            cars.Add(member);
        }

        public void Drive(string model, int km)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].model == model)
                {
                    if ((cars[i].fuelAmount - km * cars[i].fuelConsumption) >= 0)
                    {
                        cars[i].distanceTravelled += km;
                        cars[i].fuelAmount -= cars[i].fuelConsumption * km;
                    }
                    else
                    {
                    Console.WriteLine("Insufficient fuel for the drive");
                    }
                    break;
                }
            }
        }

        public void PrintResults()
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model} {car.fuelAmount:f2} {car.distanceTravelled}");
            }
        }
    }

