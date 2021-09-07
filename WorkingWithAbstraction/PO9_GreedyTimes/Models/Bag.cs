namespace PO9_GreedyTimes.Models
{
    public class Bag
    {
        private Gold gold;
        private Currency currency;
        private Gem gem;
        public Bag(int capacity)
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
        public Currency Currency
        {
            get => this.currency;
        }
        public int Capacity { get; }

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
                if (!(this.gem.Amount + curCurrencyAmount > this.gold.Amount))
                {
                    this.gem.AddGem(curCurrencyAmount);
                }
            }
        }



        private bool IsCapacityReached(long amount)
        {
            if (amount + this.gold.Amount + this.gem.Amount + this.currency.Amount <= this.Capacity)
            {
                return false;
            }

            return true;
        }
    }
}
