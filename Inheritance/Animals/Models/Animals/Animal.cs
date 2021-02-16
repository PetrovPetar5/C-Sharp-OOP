namespace Animals.Models.Animals
{
    using System;
    using System.Text;

    public abstract class Animal
    {
        private const Int32 MIN_AGE_VALUE = 0;
        private const String EXCEPTION_INPUT_MESSAGE = "Invalid input!";
        private string name;
        private int age;
        private string gender;
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(EXCEPTION_INPUT_MESSAGE);
                }

                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < MIN_AGE_VALUE)
                {
                    throw new ArgumentException(EXCEPTION_INPUT_MESSAGE);
                }

                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                if (value != "Female" && value != "Male")
                {
                    throw new ArgumentException(EXCEPTION_INPUT_MESSAGE);
                }

                this.gender = value;
            }
        }
        public abstract string ProduceSound();
       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine(this.ProduceSound());

            return sb.ToString().Trim();
        }
    }
}
