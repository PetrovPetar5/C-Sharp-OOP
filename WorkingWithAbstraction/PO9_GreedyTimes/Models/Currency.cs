using System.Collections.Generic;

namespace PO9_GreedyTimes.Models
{
    public class Cash
    {
        private long amount;
        private Dictionary<string, long> types;

        private Cash()
        {
            this.types = new Dictionary<string, long>();
        }

        public long Amount
        {
            get => this.amount;
        }

        public void AddCurrency(long amount)
        {
            this.amount += amount;
        }
    }
}
