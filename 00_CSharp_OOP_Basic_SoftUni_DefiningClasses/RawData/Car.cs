using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Car
    {
        public Car(string newModel, Engine newEngine, Cargo newCargo, ICollection<Tire> newTires)
        {
            model = newModel;
            engine = newEngine;
            cargo = newCargo;
            tires = new List<Tire>(newTires.Take(4));
        }

        public string model { get; set; }
        public Engine engine { get; set; }
        public Cargo cargo { get; set; }
        public ICollection<Tire> tires { get; set; }


}

