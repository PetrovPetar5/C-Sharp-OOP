namespace P04_HotelReservation
{
    using P04_HotelReservation.Enums;
    public static class PriceCalculator
    {
        public static decimal CalculateVacationCost(decimal dailyPrice, short days, SeasonMultiplier seasonMultiplier, DiscountTypes discountTypes)
        {
            var multiplier = (int)seasonMultiplier;
            var discount = 1 - (((int)discountTypes) / 100m);
            var holidayCost = dailyPrice * days * multiplier * discount;
            return holidayCost;
        }
    }
}
