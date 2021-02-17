using System;

namespace PersonsInfo.Models
{
    public class Person
    {
        private const string firstNameExceptionMessage = "First name cannot contain fewer than 3 symbols!";
        private const string lastNameExceptionMessage = "Last name cannot contain fewer than 3 symbols!";
        private const string salaryExceptionMessage = "Salary cannot be less than 460 leva!";
        private const string ageExceptionMessage = "Age cannot be zero or a negative integer!";
        private const int minNameLength = 3;
        private const int minAgeRequired = 1;
        private const decimal  minSalaryRequired = 460m;

        private string firstName;
        private string lasttName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (value.Length < minNameLength || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(firstNameExceptionMessage);
                }

                this.firstName = value;
            }
        }
        public string LastName
        {
            get => this.lasttName;
            private set
            {
                if (value.Length < minNameLength || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(lastNameExceptionMessage);
                }

                this.lasttName = value;
            }
        }
        public int Age
        {
            get => this.age;
            private set
            {
                if (value < minAgeRequired)
                {
                    throw new ArgumentException(ageExceptionMessage);
                }

                this.age = value;
            }
        }
        public decimal Salary
        {
            get => this.salary;
            private set
            {
                if (value < minSalaryRequired)
                {
                    throw new ArgumentException(salaryExceptionMessage);
                }

                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            var increaseDelimeter = 100;
            if (this.Age < 30)
            {
                increaseDelimeter = 200;
            }

            this.Salary += percentage * this.Salary / increaseDelimeter;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}
