﻿namespace MilitaryElite
{
    using MilitaryElite.Core;
    using MilitaryElite.Core.Contracts;
    using MilitaryElite.IO.Contracts;
    using MilitaryElite.IO.Models;
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
