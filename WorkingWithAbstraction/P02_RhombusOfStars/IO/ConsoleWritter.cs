namespace P02_RhombusOfStars.IO
{
    using System;
    public class ConsoleWritter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
