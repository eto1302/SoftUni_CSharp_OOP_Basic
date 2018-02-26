using System;
using System.Collections.Generic;
using System.Text;


    class Dough
    {
        public string flourType;
        public string bakingTechnique;
        public int weight;

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            set { this.flourType = value; }
        }
        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            set { this.bakingTechnique = value; }
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set { this.weight = value; }
        }

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            if (bakingTechnique.ToLower() != "crispy" && bakingTechnique.ToLower() != "chewy" && bakingTechnique.ToLower() != "homemade") Console.WriteLine("Invalid type of dough.");
            if (flourType.ToLower() != "white" && flourType.ToLower() != "wholegrain") Console.WriteLine("Invalid type of dough.");
            if (weight <1 || weight >200) Console.WriteLine("Dough weight should be in the range [1..200].");
            if ((bakingTechnique.ToLower() == "crispy" || bakingTechnique.ToLower() == "chewy" || bakingTechnique.ToLower() == "homemade") &&
                (flourType.ToLower() == "white" || flourType.ToLower() == "wholegrain") &&
                (weight >= 1 && weight <= 200))
            {
                this.bakingTechnique = bakingTechnique;
                this.flourType = flourType;
                this.weight = weight;
            }

    }
}

