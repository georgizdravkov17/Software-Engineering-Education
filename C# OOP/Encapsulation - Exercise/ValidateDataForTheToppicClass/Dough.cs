using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
   public class Dough
    {
        private const string DOUGH_ERROR = "Invalid type of dough...";
        private const double BASE_CALORIES = 2;

        private string floorType;
        private string backingTehnique;
        private double weight;
        
        

        public Dough(string floorType,string backingTehnique,double weight)
        {
            this.FloorType = floorType;
            this.BackingTechnique = backingTehnique;
            this.Weight = weight;
        }

        public string FloorType
        {
            get
            {
                return this.floorType;
            }
            private set
            {
                if(value != "White" && value != "Wholegrain")
                {
                    throw new ArgumentException(DOUGH_ERROR);
                }

                this.floorType = value;
            }
        }

        public string BackingTechnique
        {
            get
            {
                return this.backingTehnique;
            }
            private set
            {
                if(value != "Cripsy" && value != "Chewy" && value != "Homemade")
                {
                    throw new ArgumentException(DOUGH_ERROR);
                }

                this.backingTehnique = value;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough must be in range [1 to 200]");
                }

                this.weight = value;
            }
        }

        public double BackingTechniqueCaloriesSet()
        {
            double backingCalories = 0;
            if(this.BackingTechnique == "Cripsy")
            {
                backingCalories = 0.9;
            }
            else if(this.BackingTechnique == "Chewy")
            {
                backingCalories = 1.1;
            }
            else
            {
                backingCalories = 1.0;
            }

            return backingCalories;
        }

        public double FloorTypeCaloriesSet()
        {

            var result = this.FloorType == "White" ? 1.5 : 1.0;
            return result;
        }

        public double TotalCalories()
        {
            var result = (this.Weight * BASE_CALORIES) * FloorTypeCaloriesSet() * BackingTechniqueCaloriesSet();
            return result;
        }
    }
}
