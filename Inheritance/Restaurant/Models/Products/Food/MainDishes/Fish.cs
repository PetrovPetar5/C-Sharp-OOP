namespace Restaurant.Models.Products.Food.MainDishes
{
    public class Fish : MainDish
    {
        private const double DEFAULT_GRAMS = 22;
        public Fish(string name, decimal price) : base(name, price, DEFAULT_GRAMS)
        {
        }
    }
}
