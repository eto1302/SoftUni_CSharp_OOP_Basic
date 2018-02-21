using System;
using System.Collections.Generic;
using System.Text;

    public class Car
    {
        public string model;
        public string Model { get => model; set => model = value; }
        public string engine;
        public string Engine { get => engine; set => engine = value; }
        public int? carWeight;
        public int? CarWeight { get => carWeight; set => carWeight = value; }
        public string color;
        public string Color { get => color; set => color = value; }

    public Car(string newModel, string newEngine, int? newCarWeight, string newColor)
        {
            model = newModel;
            engine = newEngine;
            carWeight = newCarWeight;
            color = newColor;
        }
}
    

