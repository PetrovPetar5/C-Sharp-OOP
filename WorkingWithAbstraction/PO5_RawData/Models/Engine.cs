namespace PO5_RawData.Models
{
    public class Engine
    {
        public Engine(short speed, short power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public short Speed { get; private set; }
        public short Power { get; private set; }
    }
}
