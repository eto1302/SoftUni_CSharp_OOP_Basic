using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Entries : IId
    {
        private string name;
        private string id;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public Entries(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public void Check(string number)
        {
            if (this.Id.Substring(this.id.Length  - number.Length) == number)
            {
                Console.WriteLine(this.Id);
            }
        }
    }
}
