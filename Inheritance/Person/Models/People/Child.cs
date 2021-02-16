namespace Person.Models
{
    using System;
    public class Child : Person
    {
        private const int MaxAgeAllowed = 15;
        public Child(string name, int age) : base(name, age)
        {
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            protected set
            {
                if (value > MaxAgeAllowed)
                {
                    throw new ArgumentException("A child cannot be older than 15 years old.");
                }

                base.Age = value;
            }
        }
    }
}
