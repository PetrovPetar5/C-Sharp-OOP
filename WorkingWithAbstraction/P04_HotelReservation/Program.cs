namespace P04_HotelReservation
{
    using P04_HotelReservation.Enums;
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var vacationDetails = Console.ReadLine()
                                         .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var pricePerDay = decimal.Parse(vacationDetails[0]);
            var daysStayed = short.Parse(vacationDetails[1]);
            var seasonMultiplier = (SeasonMultiplier)Enum.Parse(typeof(SeasonMultiplier), vacationDetails[2], true);
            var discountType = vacationDetails.Length==4?
                (DiscountTypes)Enum.Parse(typeof(DiscountTypes), vacationDetails[3], true) : DiscountTypes.None ;
            var holidayCost = Math.Round(PriceCalculator.CalculateVacationCost(pricePerDay, daysStayed, seasonMultiplier, discountType), 2);
            Console.WriteLine(holidayCost);
        }
    }
}
