namespace NeedForSpeed.Models.Vehicles.Cars
{
    public class SportCar : Car
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 10;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
        public override double DefaultFuelConsumption => DEFAULT_FUEL_CONSUMPTION;
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
