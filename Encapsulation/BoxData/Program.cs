using System;

namespace BoxData
{
    public class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            try
            {
                Box curBox = new Box(length, width, height);
                Console.WriteLine($"Surface Area - {curBox.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {curBox.LateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {curBox.Volume():f2}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
