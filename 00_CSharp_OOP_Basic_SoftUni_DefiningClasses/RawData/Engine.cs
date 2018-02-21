using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


    class Engine
    {
        public Engine(int newSpeed, int newPower)
        {
            speed = newSpeed;
            power = newPower;
        }

        public int speed { get; set; }
        public int power { get; set; }
    }
