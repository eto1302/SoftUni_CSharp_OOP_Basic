using System;
using System.Collections.Generic;
using System.Text;


    class Pokemon
    {
        public string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string type;
        public string Type  
        {
            get => type;
            set => type = value;
        }

        public Pokemon(string newName, string newType)
        {
            type = newType;
            name = newName;
        }
}

