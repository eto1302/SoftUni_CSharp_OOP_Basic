using System;
using System.Collections.Generic;
using System.Text;


    class Car
    {
        public string carModel;
        public string CarModel
        {
            get => carModel;
            set => carModel = value;
        }
        public int carSpeed;
        public int CarSpeed
        {
            get => carSpeed;
            set => carSpeed = value;
        }

        public Car(string newCarModel, int newCarSpeed)
        {
            carSpeed = newCarSpeed;
            carModel = newCarModel;
        }
    } 
