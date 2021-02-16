namespace NeedForSpeed
{
    using Models.Vehicles.Cars;
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car curCar = new SportCar(55, 100);
            curCar.Drive(5);
        }
    }
}
