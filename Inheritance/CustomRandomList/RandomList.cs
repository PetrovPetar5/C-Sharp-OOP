namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random rand = new Random();
            var index = rand.Next(0, this.Count);
            var removedString = this[index];
            this.Remove(removedString);

            return removedString;
        }
    }
}
