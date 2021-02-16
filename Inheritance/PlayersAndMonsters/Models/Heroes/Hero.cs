namespace PlayersAndMonsters.Models.Heroes
{
    using System;
    public abstract class Hero
    {
        private string userName;
        private int level;

        public Hero(string userName, int level)
        {
            this.UserName = userName;
            this.Level = level;
        }

        public string UserName
        {
            get
            {
                return this.userName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace.");
                }

                this.userName = value;
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Level cannot be a negative number.");
                }

                this.level = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.UserName} Level: {this.Level}";
        }
    }
}
