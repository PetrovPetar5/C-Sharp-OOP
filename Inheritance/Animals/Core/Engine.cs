namespace Animals.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Animals.Models.Animals;
    using Animals.Models.Animals.Cats;
    using Animals.Models.Animals.Dogs;
    using Animals.Models.Animals.Frogs;
    public class Engine
    {
        private const String EXCEPTION_INPUT_MESSAGE = "Invalid input!";
        private const String END_COMMAND = "Beast!";
        private ICollection<Animal> animals;
        public Engine()
        {
            this.animals = new List<Animal>();
        }
        public void Run()
        {
            string command = String.Empty;
            while ((command = Console.ReadLine()) != END_COMMAND)
            {
                string animalType = command;
                string[] animalDetails = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                try
                {
                    Animal animal = GetAnimal(animalType, animalDetails);
                    this.animals.Add(animal);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            PrintsAnimals(this.animals);
        }

        private void PrintsAnimals(ICollection<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private Animal GetAnimal(string animalType, string[] animalDetails)
        {
            string name = animalDetails[0];
            int age = int.Parse(animalDetails[1]);
            string gender = String.Empty;
            if (animalDetails.Length == 3)
            {
                gender = animalDetails[2];
            }

            Animal animal = null;
            if (animalType == "Cat")
            {
                animal = new Cat(name, age, gender);
            }
            else if (animalType == "Tomcat")
            {
                animal = new Tomcat(name, age);
            }
            else if (animalType == "Kitten")
            {
                animal = new Kitten(name, age);
            }
            else if (animalType == "Dog")
            {
                animal = new Dog(name, age, gender);
            }
            else if (animalType == "Frog")
            {
                animal = new Frog(name, age, gender);
            }
            else
            {
                throw new ArgumentException(EXCEPTION_INPUT_MESSAGE);
            }

            return animal;
        }
    }
}
