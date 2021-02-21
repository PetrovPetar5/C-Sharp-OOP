namespace BorderControl.Core
{
    using System;
    using System.Collections.Generic;
    using BorderControl.Models;
    using Contracts;
    public class Engine
    {
        private ICollection<IIdentifiable> inhabitans;
        public Engine()
        {
            this.inhabitans = new List<IIdentifiable>();
        }
        public void Run()
        {
            var command = String.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                IIdentifiable inhabitant = null;
                var commandArgs = command.Split(' ');
                if (commandArgs.Length == 2)
                {
                    var robotModel = commandArgs[0];
                    var robotId = commandArgs[1];
                    inhabitant = new Robot(robotModel, robotId);
                }
                else if (commandArgs.Length == 3)
                {
                    var citizenName = commandArgs[0];
                    var citizenAge = int.Parse(commandArgs[1]);
                    var citizenId = commandArgs[2];
                    inhabitant = new Citizen(citizenName, citizenAge, citizenId);
                }

                this.inhabitans.Add(inhabitant);
            }

            var fakeIdLastDigit = Console.ReadLine();

            foreach (IIdentifiable inhabitant in inhabitans)
            {
                if (inhabitant.Id.EndsWith(fakeIdLastDigit))
                {
                    Console.WriteLine(inhabitant.Id);
                }
            }
        }
    }
}
