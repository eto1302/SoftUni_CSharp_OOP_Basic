using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

    class Solve
    {
        
        List<Car> cars = new List<Car>();

        public void AddCars(Car member)
        {
            cars.Add(member);
        }

        public void PrintResultsFragile()
        {
            foreach (var car in cars.Where(p => p.cargo.type=="fragile"&&p.tires.Where(k => k.pressure<1).Count()>0))
            {
                Console.WriteLine(car.model);
            }
        }

        public void PrintResultsFlamable()
        {
        foreach (var car in cars.Where(p => p.cargo.type == "flamable" && p.engine.power>250))
        {
            Console.WriteLine(car.model);
        }
    }
        
    }


