using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    class Ferrari : IFerrari
    {
        private string driverName;

        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }

        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
        }
        
        public void PrintMessage()
        {
            Console.WriteLine($"488-Spider/Brakes!/Zadu6avam sA!/{this.driverName}");
        }
    }
}
