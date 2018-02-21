using System;
using System.Collections.Generic;
using System.Text;


    class Cargo
    {
        public Cargo(int newWeight, string newType)
        {
            weight = newWeight;
            type = newType;
        }

        public int weight { get; set; }
        public string type { get; set; }
    }

