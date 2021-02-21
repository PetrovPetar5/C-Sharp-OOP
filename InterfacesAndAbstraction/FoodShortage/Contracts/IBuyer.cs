namespace FoodShortage.Contracts
{
    public interface IBuyer
    {
        public void BuyFood();
        public int Food { get; }

        public string Name { get; }
    }
}
