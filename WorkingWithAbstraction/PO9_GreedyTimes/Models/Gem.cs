namespace PO9_GreedyTimes.Models
{
   public class Gem
    {
        private long amount;
        public long Amount
        {
            get => this.amount;
        }

        public void AddGem(long amount)
        {
            this.amount += amount;
        }
    }
}
