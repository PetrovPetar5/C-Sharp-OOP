namespace FootballTeamGenerator.Common
{
    using FootballTeamGenerator.Models;
    using System;
    public static class Validator
    {
        public static void NameValidator(string value, string NameExcMsg)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(NameExcMsg);
            }
        }

       
    }
}
