namespace PizzaCalories.Models.Ingredients
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PizzaCalories.Common;
    public class Topping
    {
        private const double MIN_WEIGHT = 1;
        private const double MAX_WEIGHT = 50;
        private const double BASE_CALORIES_PER_GRAM = 2;
       

        private readonly Dictionary<string, double> types;
        private string type;
        private double weight;
        private Topping()
        {
            this.types = new Dictionary<string, double>()
            {
                { "meat", 1.2 },
                { "veggies", 0.8 },
                { "cheese", 1.1 },
                 { "sauce", 0.9}
            };
        }
        public Topping(string type, double weight) : this()
        {
            this.Type = type;
            this.Weight = weight;
        }
        public string Type
        {
            get => this.type;
            private set
            {
                if (!this.types.ContainsKey(value.ToLower()))
                {
                    string valueString = value.First().ToString().ToUpper() + value.Substring(1);
                    string excMsg = string.Format(GlobalConstants.Topping_EXC_MESSAGE, valueString);
                    throw new ArgumentException(excMsg);
                }

                this.type = value.ToLower();
            }
        }
        public double Weight
        {
            get => this.weight;
            private set
            {
                if (!(MIN_WEIGHT <= value && value <= MAX_WEIGHT))
                {
                    string typeString =  this.Type.First().ToString().ToUpper() + this.Type.Substring(1);
                    string excMessage = String.Format(GlobalConstants.WEIGHT_EXC_MESSAGE, typeString, MIN_WEIGHT, MAX_WEIGHT);
                    throw new ArgumentException(excMessage);
                }

                this.weight = value;
            }
        }
        public double Calories => CalculateCalories();

        private double CalculateCalories()
        {
            double typeMyltiplier = this.types[this.Type];

            return this.Weight * BASE_CALORIES_PER_GRAM * typeMyltiplier;
        }
    }
}
