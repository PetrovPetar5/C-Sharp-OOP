namespace PO8_Hospital.Models
{
    using PO8_Hospital.Global;
    using System.Collections.Generic;
    public class Doctor
    {
        private string firstName;
        private string surname;
        private ICollection<Patient> patients;

        private Doctor()
        {
            this.patients = new HashSet<Patient>();
        }
        public Doctor(string firstName, string surname) : this()
        {
            this.FirstName = firstName;
            this.Surname = surname;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (NameValidator.ValidateName(value, 20))
                {
                    this.firstName = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return this.surname;
            }

            private set
            {
                if (NameValidator.ValidateName(value, 20))
                {
                    this.surname = value;
                }
            }
        }

        public IReadOnlyCollection<Patient> Patients => this.patients as IReadOnlyCollection<Patient>;

        public void AddPatient(Patient patient)
        {
            this.patients.Add(patient);
        }
    }
}
