namespace Restaurant.Models.Products.Beverages.HotBeverages
{
    using Restaurant.Models.Products.Beverages.HotBevarages;
   public class Coffee : HotBeverage
    {
        private const double COFFEE_MILLILITERS = 50;
        private const decimal COFFEE_PRICE = 3.50m;
        public Coffee(string name, double caffeine) : base(name, COFFEE_PRICE, COFFEE_MILLILITERS)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; }
    }
}
