namespace Telephony.Core
{
    using System;
    using Telephony.Exceptions;
    using Telephony.Models;
    public class Engine
    {
        private StationaryPhone stationaryPhone;
        private Smartphone smartPhone;
        public Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartPhone = new Smartphone();
        }
        public void Run()
        {
            var numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            var sites = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in numbers)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        Console.WriteLine(this.stationaryPhone.call(number));
                    }
                    else if (number.Length == 10)
                    {
                        Console.WriteLine(this.smartPhone.call(number));
                    }
                    else
                    {
                        throw new InvalidNumberException();
                    }
                }
                catch (InvalidNumberException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var site in sites)
            {
                try
                {
                    Console.WriteLine(this.smartPhone.Browse(site));
                }
                catch (InvalidURLException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
