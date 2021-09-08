namespace PO9_GreedyTimes.Models
{
    public class Gold
    {
        private long amount;
        public long Amount
        {
            get => this.amount;
        }

        public void AddGold(long amount)
        {
            this.amount += amount;
        }
    }
}
