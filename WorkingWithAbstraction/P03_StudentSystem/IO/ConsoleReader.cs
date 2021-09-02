namespace P03_StudentSystem.IO
{
    using System;
    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
