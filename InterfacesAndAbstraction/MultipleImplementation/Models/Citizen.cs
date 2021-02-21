using MultipleImplementation.Contracts;

namespace MultipleImplementation.Models
{
    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Id = id;
            this.Birthdate = birthdate;
            this.Name = name;
            this.Age = age;
        }

        public string Id { get; }

        public string Birthdate { get; }

        public string Name { get; }

        public int Age { get; }
    }
}
