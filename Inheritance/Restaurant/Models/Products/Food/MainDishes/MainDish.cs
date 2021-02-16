namespace Restaurant.Models.Products.Food.MainDishes
{
    public abstract class MainDish : Food
    {
        protected MainDish(string name, decimal price, double grams) : base(name, price, grams)
        {
        }
    }
}
