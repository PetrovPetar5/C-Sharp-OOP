namespace NeedForSpeed.Models.Vehicles.MotorCycles
{
    using NeedForSpeed.Models.Vehicles.MotorCycle;
    public class RaceMotorcycle : Motorcycle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 8;
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double DefaultFuelConsumption => DEFAULT_FUEL_CONSUMPTION;
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
