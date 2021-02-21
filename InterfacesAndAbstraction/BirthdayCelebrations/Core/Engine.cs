namespace BorderControl.Core
{
    using System;
    using System.Collections.Generic;
    using BirthdayCelebrations.Contracts;
    using BirthdayCelebrations.Models;
    using BorderControl.Models;
    public class Engine
    {
        private ICollection<IBirthable> inhabitans;
        public Engine()
        {
            this.inhabitans = new List<IBirthable>();
        }
        public void Run()
        {
            var command = String.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                IBirthable inhabitant = null;
                var commandArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var inhabitantType = commandArgs[0];
                if (inhabitantType == "Pet")
                {
                    AddPet(commandArgs);
                }
                else if (inhabitantType == "Citizen")
                {
                    AddCitizen(commandArgs);
                }
            }

            var birthYear = Console.ReadLine();
            PrintResult(birthYear);
        }

        private void AddCitizen(string[] commandArgs)
        {
            IBirthable inhabitant;
            var citizenName = commandArgs[1];
            var citizenAge = int.Parse(commandArgs[2]);
            var citizenId = commandArgs[3];
            var citizenBirthDate = commandArgs[4];
            inhabitant = new Citizen(citizenName, citizenAge, citizenId, citizenBirthDate);
            this.inhabitans.Add(inhabitant);
        }

        private void AddPet(string[] commandArgs)
        {
            IBirthable inhabitant;
            var petName = commandArgs[1];
            var petBirthdate = commandArgs[2];
            inhabitant = new Pet(petName, petBirthdate);
            this.inhabitans.Add(inhabitant);
        }

        private void PrintResult(string birthYear)
        {
            foreach (IBirthable inhabitant in inhabitans)
            {
                if (inhabitant.Birthdate.EndsWith(birthYear))
                {
                    Console.WriteLine(inhabitant.Birthdate);
                }
            }
        }
    }
}
