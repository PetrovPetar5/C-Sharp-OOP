﻿namespace BorderControl.Models
{
    using BirthdayCelebrations.Contracts;
    using Contracts;
    public class Citizen : ICitizen, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get; }

        public int Age { get; }

        public string Id { get; }

        public string Birthdate { get; }
    }
}
