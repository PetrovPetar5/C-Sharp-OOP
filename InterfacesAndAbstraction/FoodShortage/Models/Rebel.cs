namespace FoodShortage.Models
{
    using FoodShortage.Contracts;

    public class Rebel : IBuyer
    {
        private int food;
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Name { get; }
        public int Age { get; }
        public string Group { get; }

        public int Food => this.food;

        public void BuyFood()
        {
            this.food += 5;
        }
    }
}
