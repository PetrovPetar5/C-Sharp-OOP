namespace PO5_RawData
{
    using PO5_RawData.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            var numberOfCars = short.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                var curCarDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = curCarDetails[0];
                var engineSpeed = short.Parse(curCarDetails[1]);
                var enginePower = short.Parse(curCarDetails[2]);
                var cargoWeight = double.Parse(curCarDetails[3]);
                var cargoType = curCarDetails[4];
                var tiresDetails = curCarDetails.Skip(5).ToArray();
                var curEngine = new Engine(engineSpeed, enginePower);
                var curCargo = new Cargo(cargoWeight, cargoType);
                var curTires = GetCarTires(tiresDetails);
                var curCar = new Car(model, curEngine, curCargo, curTires);
                cars.Add(curCar);
            }

            var carTypeCondition = Console.ReadLine().ToLower();
            var carsSelectedByCondition = new List<Car>();
            switch (carTypeCondition)
            {
                case "flamable":
                    carsSelectedByCondition = cars.Where(x => x.Cargo.Type.ToLower() == carTypeCondition && x.Engine.Power > 250).ToList();
                    break;
                case "fragile":
                    carsSelectedByCondition = cars.Where(x => x.Cargo.Type.ToLower() == carTypeCondition && x.Tires.Any(t => t.Pressure < 1)).ToList();
                    break;
            }

            PrintsOutput(carsSelectedByCondition);
        }

        private static void PrintsOutput(List<Car> carsSelectedByCondition)
        {
            foreach (var car in carsSelectedByCondition)
            {
                Console.WriteLine(car.Model);
            }
        }

        private static Tire[] GetCarTires(string[] tiresInput)
        {
            var curTires = new Tire[4];
            var tireCounter = 0;
            for (int j = 0; j < tiresInput.Length; j += 2)
            {
                var curTirePressure = double.Parse(tiresInput[j]);
                var curTireAge = short.Parse(tiresInput[j + 1]);
                curTires[tireCounter] = new Tire(curTirePressure, curTireAge);
                tireCounter++;
            }

            return curTires;
        }
    }
}
