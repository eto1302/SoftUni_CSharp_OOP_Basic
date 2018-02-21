using System;
using System.Collections.Generic;
using System.Text;

    public class Engine
    {
        public string model;
        public string Model { get => model; set => model = value; }
        public int power;
        public int Power{ get => power; set => power = value; }
        public int? displacement;
        public int? Displacement { get => displacement; set => displacement = value; }
        public string efficiency;
        public string Efficiency { get => efficiency; set => efficiency = value; }

        public  Engine(string newModel, int newPower, int? newDisplacement, string newEfficiency)
        {
            model = newModel;
            power = newPower;
            displacement = newDisplacement;
            efficiency = newEfficiency;
        }
}