namespace FootballTeamGenerator.Models
{
    using Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Team
    {
        private const string PlayerDoesNotExistInTheCurrentTeamMessage = "Player {0} is not in {1} team.";
        private readonly List<Player> players;
        private string name;

        private Team()
        {
            this.players = new List<Player>();
        }
        public Team(string name) : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validator.NameValidator(value, GlobalConstants.NAME_EXC_MSG);
                this.name = value;
            }
        }

        public int Rating => CalculateRating();

        public void AddPlayer(Player player)
        {
            if (!this.players.Contains(player))
            {
                this.players.Add(player);
            }
        }

        public void RemovePlayer(string playerName)
        {
            Player curPlayer = this.players.FirstOrDefault(p => p.Name == playerName);
            if (curPlayer == null)
            {
                string excMsg = string.Format(PlayerDoesNotExistInTheCurrentTeamMessage, playerName, this.Name);
                throw new ArgumentException(excMsg);
            }

            this.players.Remove(curPlayer);
        }

        private int CalculateRating()
        {
            int rating = this.players.Count == 0 ? 0 : (int)Math.Round(this.players.Average(p => p.OverAllSkill));

            return rating;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
