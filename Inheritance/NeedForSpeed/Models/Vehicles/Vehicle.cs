namespace NeedForSpeed.Models.Vehicles
{
    public abstract class Vehicle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        public virtual double DefaultFuelConsumption => DEFAULT_FUEL_CONSUMPTION;
        public virtual double FuelConsumption { get; protected set; }

        public double Fuel { get; protected set; }
        public int HorsePower { get; protected set; }

        public virtual void Drive(double km)
        {
            double fuelReducement = this.FuelConsumption * km;
            this.Fuel -= fuelReducement;
        }
    }
}
