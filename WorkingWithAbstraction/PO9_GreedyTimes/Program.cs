namespace PO9_GreedyTimes
{
    using PO9_GreedyTimes.Models;
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var bagCapacity = long.Parse(Console.ReadLine());
            var bag = new Bag(bagCapacity);
            var treasureDetails = Console.ReadLine().Split(" ");
            for (int i = 0; i < treasureDetails.Length; i += 2)
            {
                var item = treasureDetails[i].ToLower();
                var itemAmount = long.Parse(treasureDetails[i + 1]);
                if (item == "gold")
                {
                    bag.AddGold(itemAmount);
                }
                else if (item.EndsWith("gem"))
                {
                    bag.AddGem(itemAmount);
                }
                else if (item.Length == 3)
                {
                    bag.AddCurrency(itemAmount);
                }
            }
        }
    }
}
