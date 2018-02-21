using System;
using System.Collections.Generic;
using System.Text;


    class Tire
    {
        public Tire(decimal newPressure, int newAge)
        {
            age = newAge;
            pressure = newPressure;
        }

        public int age { get; set; }
        public decimal pressure { get; set; }

    }

