namespace ShoppingSpree.Models.Products
{
    using ShoppingSpree.Common;
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validator.NameValidator(value);
                this.name = value;
            }
        }

        public decimal Cost
        {
            get => this.cost;
            private set
            {
                Validator.MoneyValidator(value);
                this.cost = value;
            }
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
