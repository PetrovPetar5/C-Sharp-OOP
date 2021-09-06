namespace PO5_RawData.Models
{
    public class Cargo
    {
        public Cargo(double weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public double Weight { get; private set; }
        public string Type { get; private set; }
    }
}
