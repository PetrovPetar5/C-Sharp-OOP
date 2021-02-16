using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Dog : Animal
    {
        public Dog()
        {

        }

        public Dog(int bittenPeople, int eatenFood,string name,string owner) :base(name,owner)
        {
            this.BittenPeople = bittenPeople;
            this.EatenFood = eatenFood;
        }
       public int BittenPeople { get; set; }
       public int EatenFood { get; set; }

        public void Bark()
        {
            Console.WriteLine("barking…");
        }
    }
}
