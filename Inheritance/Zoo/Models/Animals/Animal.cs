namespace Zoo.Models.Animals
{
    public abstract class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
