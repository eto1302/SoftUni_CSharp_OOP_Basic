using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Solve
    {
        List<Car> cars = new List<Car>();
        List<Engine> engines = new List<Engine>();
        public void AddCar(Car member)
        {
            cars.Add(member);
        }

        public void AddEngine(Engine member)
        {
            engines.Add(member);
        }

        public void PrintResults()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{cars[i].model}:");
                Console.WriteLine($"  {cars[i].engine}:");
                Console.WriteLine($"    Power: {engines.Where(p => p.model == cars[i].engine).First().power}");
                if (engines.Where(p => p.model == cars[i].engine).First().displacement != null)
                {
                Console.WriteLine($"    Displacement: {engines.Where(p => p.model == cars[i].engine).First().displacement}");
                }
                else
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                if (engines.Where(p => p.model == cars[i].engine).First().efficiency != null)
                {
                    Console.WriteLine($"    Efficiency: {engines.Where(p => p.model == cars[i].engine).First().efficiency}");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                if (cars[i].carWeight!=null)
                {
                    Console.WriteLine($"  Weight: {cars[i].carWeight}");
                }
                else
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                if (cars[i].color!=null)
                {
                    Console.WriteLine($"  Color: {cars[i].color}");
                }
                else
                {
                    Console.WriteLine($"  Color: n/a");
                }
        }
    }
    }

