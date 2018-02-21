using System;
using System.Collections.Generic;
using System.Text;


    class Parents
    {
        public string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string birthday;
        public string Birthday
        {
            get => birthday;
            set => birthday = value;
        }

        public Parents(string newName, string newBirthday)
        {
            birthday = newBirthday;
            name = newName;
        }
}

