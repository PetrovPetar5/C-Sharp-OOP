namespace FootballTeamGenerator.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FootballTeamGenerator.Models;
    using FootballTeamGenerator.Common;

    public class Engine
    {
        private readonly List<Team> teams;
        public Engine()
        {
            this.teams = new List<Team>();
        }
        public void Run()
        {
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArgs = command
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string commandType = commandArgs[0];
                string teamName = commandArgs[1];
                Team team = this.teams.FirstOrDefault(t => t.Name == teamName);
                try
                {
                    if (commandType == "Team")
                    {
                        if (team == null)
                        {
                            this.teams.Add(new Team(teamName));
                        }
                    }
                    else if (commandType == "Add")
                    {
                        ValidateTeam(teamName, team);
                        Player player = CreatePlayer(commandArgs);
                        team.AddPlayer(player);
                    }
                    else if (commandType == "Remove")
                    {
                        string playerToRemoveName = commandArgs[2];
                        ValidateTeam(teamName, team);
                        team.RemovePlayer(playerToRemoveName);
                    }
                    else if (commandType == "Rating")
                    {
                        ValidateTeam(teamName, team);
                        Console.WriteLine(team);
                    }
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static Player CreatePlayer(string[] commandArgs)
        {
            string playerName = commandArgs[2];
            int playerEndurance = int.Parse(commandArgs[3]);
            int playerSprint = int.Parse(commandArgs[4]);
            int playerDribble = int.Parse(commandArgs[5]);
            int playerPassing = int.Parse(commandArgs[6]);
            int playerShooting = int.Parse(commandArgs[7]);
            Player player = new Player(playerName, playerEndurance, playerSprint, playerDribble, playerPassing, playerShooting);
            return player;
        }

        private static void ValidateTeam(string teamName, Team team)
        {
            if (team == null)
            {
                string excMsg = string.Format(GlobalConstants.NOT_EXISTING_TEAM_MSG, teamName);
                throw new ArgumentException(excMsg);
            }
        }
    }
}
