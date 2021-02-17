namespace PizzaCalories.Core
{
    using System;
    using System.Linq;
    using PizzaCalories.Models.Ingredients;
    using PizzaCalories.Models.Pizzas;
    using PizzaCalories.Common;

    public class Engine
    {
        public void Run()
        {
            try
            {
                string[] pizzaNameArgs = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .ToArray();
                Pizza pizza = CreatePizza(pizzaNameArgs);
                string[] doughArgs = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .ToArray();
                pizza.Dough = CreateDough(doughArgs);
                string command = String.Empty;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] toppingArgs = command
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .ToArray();
                    AddToppingToPizza(pizza, toppingArgs);
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void AddToppingToPizza(Pizza pizza, string[] toppingArgs)
        {
            string toppingType = toppingArgs[1];
            double toppingWeight = double.Parse(toppingArgs[2]);
            Topping toping = new Topping(toppingType, toppingWeight);
            pizza.AddTopping(toping);
        }
        private static Dough CreateDough(string[] doughArgs)
        {
            string flourType = doughArgs[1];
            string bakingTechnique = doughArgs[2];
            double weight = double.Parse(doughArgs[3]);

            return new Dough(flourType, bakingTechnique, weight);
        }

        private static Pizza CreatePizza(string[] pizzaName)
        {
            if (pizzaName.Length == 1)
            {
                string excMsg = string.Format(GlobalConstants.PIZZA_EXC_MESSAGE, 1, 15);
                throw new ArgumentException(excMsg);
            }
            string name = pizzaName[1];
            Pizza pizza = new Pizza(name);

            return pizza;
        }
    }
}
