namespace Person.Models
{
    using System;
    using System.Text;
    public class Person
    {
        private const int MinAgeAllowed = 0;
        private  readonly string name;
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value < MinAgeAllowed)
                {
                    throw new ArgumentException("Person's age cannot be less than zero.");
                }

                this.age = value;
            }
        }

        public string Name { get; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();
        }

    }
}

