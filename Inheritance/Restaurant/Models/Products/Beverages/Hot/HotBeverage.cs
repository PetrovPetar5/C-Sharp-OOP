namespace Restaurant.Models.Products.Beverages.HotBevarages
{
    public abstract class HotBeverage : Beverage
    {
        protected HotBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }
}
