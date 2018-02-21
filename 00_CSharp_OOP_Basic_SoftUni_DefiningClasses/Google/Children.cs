using System;
using System.Collections.Generic;
using System.Text;

    class Children
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

        public Children(string newName, string newBirthday)
        {
            birthday = newBirthday;
            name = newName;
        }
}

