namespace ShoppingSpree.Models.People
{
    using System.Collections.Generic;
    using ShoppingSpree.Common;
    using ShoppingSpree.Models.Products;
    public class Person
    {
        private string name;
        private decimal money;
        private readonly ICollection<Product> bagOfProducts;

        private Person()
        {
            this.bagOfProducts = new List<Product>();
        }
        public Person(string name, decimal money) : this()
        {
            this.Name = name;
            this.Money = money;
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

        public decimal Money
        {
            get => this.money;
            private set
            {
                Validator.MoneyValidator(value);
                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> BagOfProducts => (IReadOnlyCollection<Product>)this.bagOfProducts;

        public string BuyProduct(Product product)
        {
            bool enoughMoneyToBuyProduct = product.Cost <= this.Money;
            if (!enoughMoneyToBuyProduct)
            {
                return $"{this.Name} can't afford {product.Name}";
            }

            this.Money -= product.Cost;
            this.bagOfProducts.Add(product);

            return $"{this.Name} bought {product.Name}";
        }

        public override string ToString()
        {
            var result = this.bagOfProducts.Count != 0 ? string.Join(", ", this.BagOfProducts) : "Nothing bought";

            return $"{this.Name} - {result}";
        }
    }
}
