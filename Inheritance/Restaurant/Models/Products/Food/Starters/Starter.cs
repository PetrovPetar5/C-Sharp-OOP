﻿namespace Restaurant.Models.Products.Food.Starters
{
    public abstract class Starter : Food
    {
        protected Starter(string name, decimal price, double grams) : base(name, price, grams)
        {
        }
    }
}
