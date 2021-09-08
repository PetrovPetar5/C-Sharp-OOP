namespace PO9_GreedyTimes.Models
{
    public class Bag
    {
        private Gold gold;
        private Cash cash;
        private Gem gem;
        public Bag(long capacity)
        {
            this.Capacity = capacity;
        }

        public Gold Gold
        {
            get => this.gold;
        }
        public Gem Gems
        {
            get => this.gem;
        }
        public Cash Currency
        {
            get => this.cash;
        }
        public long Capacity { get; }

        public void AddGold(long curGoldAmount)
        {
            var isReached = IsCapacityReached(curGoldAmount);
            if (!isReached)
            {
                this.gold.AddGold(curGoldAmount);
            }
        }

        public void AddGem(long curGemAmount)
        {
            var isReached = IsCapacityReached(curGemAmount);
            if (!isReached)
            {
                if (!(this.gem.Amount + curGemAmount > this.gold.Amount))
                {
                    this.gem.AddGem(curGemAmount);
                }
            }
        }
        public void AddCurrency(long curCurrencyAmount)
        {
            var isReached = IsCapacityReached(curCurrencyAmount);
            if (!isReached)
            {
                if (!(this.cash.Amount + curCurrencyAmount > this.gem.Amount))
                {
                    this.cash.AddCurrency(curCurrencyAmount);
                }
            }
        }

        private bool IsCapacityReached(long amount)
        {
            if (amount + this.gold.Amount + this.gem.Amount + this.cash.Amount <= this.Capacity)
            {
                return false;
            }

            return true;
        }
    }
}
