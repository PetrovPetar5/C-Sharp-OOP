namespace PO5_RawData.Models
{
    public class Tire
    {
        public Tire(double pressure, short age )
        {
            this.Pressure = pressure;
            this.Age = age;
        }
        public double Pressure { get; private set; }
        public short Age { get; private set; }
    }
}
