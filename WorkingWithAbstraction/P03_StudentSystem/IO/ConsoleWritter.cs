namespace P03_StudentSystem.IO
{
    using System;
    public class ConsoleWritter : IWritter
    {
        public void Write(string input)
        {
            Console.WriteLine(input);
        }
    }
}
