namespace PizzaCalories.Models.Pizzas
{
    using PizzaCalories.Common;
    using PizzaCalories.Models.Ingredients;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Pizza
    {
        private const int MIN_NAME_LENGTH = 1;
        private const int MAX_NAME_LENGTH = 15;
        private const int MAX_TOPPINGS_COUNT = 10;
        private const int MIN_TOPPINGS_COUNT = 0;
       
        private const string TOPPINGS_COUNT_EXC_MESSAGE = "Number of toppings should be in range[{0}..{1}].";
        private string name;
        private readonly List<Topping> toppings;
        private Dough dough;

        private Pizza()
        {
            this.toppings = new List<Topping>();
        }

        public Pizza(string name) : this()
        {
            this.Name = name;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                bool meetLenghtRequirement = MIN_NAME_LENGTH <= value.Length && value.Length <= MAX_NAME_LENGTH;
                if (!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || meetLenghtRequirement))
                {
                    string excMsg = String.Format(GlobalConstants.PIZZA_EXC_MESSAGE, MIN_NAME_LENGTH, MAX_NAME_LENGTH);
                    throw new ArgumentException(excMsg);
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            get => this.dough;
            set => this.dough = value;
        }

        public int ToppingsCount => this.toppings.Count;

        public double Calories => CalculateCalories();

        public void AddTopping(Topping toping)
        {
            if (this.toppings.Count == MAX_TOPPINGS_COUNT)
            {
                string excMsg = String.Format(TOPPINGS_COUNT_EXC_MESSAGE, MIN_TOPPINGS_COUNT, MAX_TOPPINGS_COUNT);
                throw new ArgumentException(excMsg);
            }

            this.toppings.Add(toping);
        }
        private double CalculateCalories()
        {
            double totalCalories = this.dough.Calories + this.toppings.Sum(t => t.Calories);

            return totalCalories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Calories:F2} Calories.";
        }
    }
}
