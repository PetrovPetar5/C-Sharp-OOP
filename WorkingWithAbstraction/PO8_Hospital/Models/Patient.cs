namespace PO8_Hospital.Models
{
    using PO8_Hospital.Global;
    using System;
    public class Patient
    {
        private string name;
        private Room room;

        public Patient(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (NameValidator.ValidateName(value, 20))
                {
                    this.name = value;
                }
            }
        }
        public Room Room => this.room;

        public void AddRoom(Room room)
        {
            this.room = room;
        }

        public override string ToString()
        {
            var toPrint = this.Name;
            return toPrint;
        }
    }
}
