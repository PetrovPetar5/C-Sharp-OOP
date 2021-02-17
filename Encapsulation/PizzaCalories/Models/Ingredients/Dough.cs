namespace PizzaCalories.Models.Ingredients
{
    using System;
    using System.Collections.Generic;
    using PizzaCalories.Common;
    public class Dough
    {
        private const double MIN_WEIGHT = 1;
        private const double MAX_WEIGHT = 200;
        private const double BASE_CALORIES_PER_GRAM = 2;
        private const string INVALID_DOUGHT_EXC_MESSAGE = "Invalid type of dough.";

        private readonly Dictionary<string, double> flourMultipliers;
        private readonly Dictionary<string, double> bakingTechniqueMultipliers;
        private string flourType;
        private string bakingTechnique;
        private double weight;

        private Dough()
        {
            this.flourMultipliers = new Dictionary<string, double>()
        {
                { "white", 1.5 },
                { "wholegrain", 1.0 }
            };

            this.bakingTechniqueMultipliers = new Dictionary<string, double>()
            {
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1.0 }
            };
        }
        public Dough(string flourType, string bakingTechnique, double weight) : this()
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                ValidateIfInputExistInOurCollection(this.flourMultipliers, value.ToLower());

                this.flourType = value.ToLower();
            }
        }
        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                ValidateIfInputExistInOurCollection(this.bakingTechniqueMultipliers, value.ToLower());

                this.bakingTechnique = value.ToLower();
            }
        }
        public double Weight
        {
            get => this.weight;
            private set
            {
                if (!(MIN_WEIGHT <= value && value <= MAX_WEIGHT))
                {
                    string excMessage = String.Format(GlobalConstants.WEIGHT_EXC_MESSAGE, this.GetType().Name, MIN_WEIGHT, MAX_WEIGHT);
                    throw new ArgumentException(excMessage);
                }

                this.weight = value;
            }
        }
        public double Calories => CalculateCalories();

        private double CalculateCalories()
        {
            double flourMultiplier = this.flourMultipliers[this.FlourType];
            double bakingMultiplier = this.bakingTechniqueMultipliers[this.BakingTechnique];

            return this.Weight * BASE_CALORIES_PER_GRAM * flourMultiplier * bakingMultiplier;
        }

        private void ValidateIfInputExistInOurCollection(Dictionary<string, double> collection, string input)
        {
            if (!collection.ContainsKey(input))
            {
                throw new ArgumentException(INVALID_DOUGHT_EXC_MESSAGE);
            }
        }
    }
}

