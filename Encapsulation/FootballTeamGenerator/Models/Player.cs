namespace FootballTeamGenerator.Models
{
    using FootballTeamGenerator.Common;
    using System;
    public class Player
    {
        private const double StatCount = 5;
        private const string StatExcMsg = "{0} should be between {1} and {2}.";
       
        private const int MinStatValue = 0;
        private const int MaxStatValue = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
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
        public int Endurance
        {
            get => this.endurance;
            private set
            {
                ValidateStat(value, nameof(this.Endurance));
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get => this.sprint;
            private set
            {
                ValidateStat(value, nameof(this.Sprint));
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get => this.dribble;
            private set
            {
                ValidateStat(value, nameof(this.Dribble));
                this.dribble = value;
            }
        }

        public int Passing
        {
            get => this.passing;
            private set
            {
                ValidateStat(value, nameof(this.Passing));
                this.passing = value;
            }
        }

        public int Shooting
        {
            get => this.shooting;
            private set
            {
                ValidateStat(value, nameof(this.Shooting));
                this.shooting = value;
            }
        }

        public double OverAllSkill => GetAverageStat();

        private static void ValidateStat(int value, string stat)
        {
            if (!(MinStatValue <= value && value <= MaxStatValue))
            {
                string exceptionMessage = string.Format(StatExcMsg, stat, MinStatValue, MaxStatValue);
                throw new ArgumentException(exceptionMessage);
            }
        }

        private double GetAverageStat()
        {
            double averageStat = (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / StatCount;

            return averageStat;
        }
    }
}
