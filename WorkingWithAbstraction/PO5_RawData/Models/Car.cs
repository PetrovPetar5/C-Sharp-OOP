namespace PO5_RawData.Models
{
    using System.Collections.Generic;
    public class Car
    {
        private ICollection<Tire> tires;

        private Car()
        {
            this.tires = new List<Tire>();
        }
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires) : this()
        {
            this.tires = tires;
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }

        public string Model { get; private set; }
        public Engine Engine { get; private set; }
        public Cargo Cargo { get; private set; }

        public IReadOnlyCollection<Tire> Tires => (IReadOnlyCollection<Tire>)this.tires;

    }
}
