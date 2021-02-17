namespace ShoppingSpree.Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using ShoppingSpree.Models.People;
    using ShoppingSpree.Models.Products;
    public class Engine
    {
        private ICollection<Person> people;
        private ICollection<Product> products;
        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                var peopleData = Console.ReadLine().Split(';')
                    .ToArray();
                AddsPerson(peopleData);
                var productsData = Console.ReadLine().Split(';')
                    .ToArray();
                AddsProduct(productsData);
                var command = String.Empty;
                while ((command = Console.ReadLine()) != "END")
                {
                    var commandArgs = command
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    var person = this.people.FirstOrDefault(p => p.Name == commandArgs[0]);
                    var product = this.products.FirstOrDefault(p => p.Name == commandArgs[1]);
                    if (person != null && product != null)
                    {
                        Console.WriteLine(person.BuyProduct(product));
                    }
                }

                    PrintsOutput();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NotSupportedException ex)
            {

            }
            catch (IndexOutOfRangeException ex)
            {

            }
        }
        private void PrintsOutput()
        {
            foreach (var person in this.people)
            {
                Console.WriteLine(person);
            }
        }

        private void AddsProduct(string[] productsData)
        {
            foreach (var product in productsData)
            {
                var productArgs = product
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var name = productArgs[0];
                var cost = Decimal.Parse(productArgs[1]);
                var curProduct = new Product(name, cost);
                this.products.Add(curProduct);
            }
        }

        private void AddsPerson(string[] peopleData)
        {
            foreach (var person in peopleData)
            {
                var personArgs = person
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = personArgs[0];
                var money = Decimal.Parse(personArgs[1]);
                var curPerson = new Person(name, money);
                this.people.Add(curPerson);
            }
        }
    }
}


