namespace BorderControl.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BorderControl.Models;
    using FoodShortage.Contracts;
    using FoodShortage.Models;
    public class Engine
    {
        private ICollection<IBuyer> merchants;
        public Engine()
        {
            this.merchants = new HashSet<IBuyer>();
        }
        public void Run()
        {
            var numberOfInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputs; i++)
            {
                AddMerchants();
            }

            var command = String.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                if (this.merchants.Any(m => m.Name == command))
                {
                    var mercant = this.merchants.First(n => n.Name == command);
                    mercant.BuyFood();
                }
            }

            Console.WriteLine(this.merchants.Sum(m => m.Food));
        }

        private void AddMerchants()
        {
            var buyerArgs = Console.ReadLine().Split(' ');
            IBuyer buyer = null;
            var name = buyerArgs[0];
            var age = int.Parse(buyerArgs[1]);
            if (buyerArgs.Length == 3)
            {
                var group = buyerArgs[2];
                buyer = new Rebel(name, age, group);
            }
            else
            {
                var iD = buyerArgs[2];
                var birthDate = buyerArgs[3];
                buyer = new Citizen(name, age, iD, birthDate);
            }

            this.merchants.Add(buyer);
        }
    }
}
