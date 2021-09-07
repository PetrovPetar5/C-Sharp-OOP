namespace PO8_Hospital.Models
{
    using PO8_Hospital.Global;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Department
    {

        private string name;
        private ICollection<Patient> patients;
        private Room[] rooms;

        private Department()
        {
            this.patients = new List<Patient>();
            this.rooms = new Room[20];
            CreateRooms();
        }
        public Department(string name) : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (NameValidator.ValidateName(value, 100))
                {
                    this.name = value;
                }
            }
        }
        public IReadOnlyCollection<Patient> Patients => this.patients as IReadOnlyCollection<Patient>;
        public void AddPatient(Patient patient)
        {
            foreach (var room in this.rooms)
            {
                if (room.VacantBed())
                {
                    patient.AddRoom(room);
                    this.patients.Add(patient);
                    break;
                }
            }
        }
        public Room GetRoom(int roomNumber)
        {
            return this.rooms[roomNumber];
        }
        private void CreateRooms()
        {
            for (int i = 0; i < 20; i++)
            {
                this.rooms[i] = new Room(i + 1);
            }
        }
    }
}
