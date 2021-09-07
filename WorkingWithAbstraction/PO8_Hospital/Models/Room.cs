using System.Collections.Generic;
namespace PO8_Hospital.Models
{
    public class Room
    {
        private int beds = 3;
        private ICollection<Patient> patients;
        private Room()
        {
            this.patients = new HashSet<Patient>();
        }
        public Room(int number) : this()
        {
            this.Number = number;
        }

        public int Number { get; private set; }

        public bool VacantBed()
        {
            if (this.beds == 0)
            {
                return false;
            }
            else
            {
                this.beds--;
                return true;
            }
        }
    }
}
