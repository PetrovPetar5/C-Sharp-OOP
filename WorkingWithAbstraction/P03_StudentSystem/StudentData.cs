namespace P03_StudentSystem
{
    using P03_StudentSystem.Commands;
    using P03_StudentSystem.IO;
    using System.Collections.Generic;
    public class StudentData
    {
        private Dictionary<string, ICommand> commands;
        public StudentData()
        {
            this.Repository = new Dictionary<string, Student>();
            this.commands = new Dictionary<string, ICommand>()
            {
                { "Create", new CreateCommand() },
                { "Show", new ShowCommand()},
            };
        }

        public Dictionary<string, Student> Repository { get; private set; }

        public void ParseCommand(IReader reader)
        {
            while (true)
            {
                string[] args = reader.Read().Split();
                var commandName = args[0];

                if (this.commands.ContainsKey(commandName))
                {
                    var command = this.commands[commandName];
                    command.Execute(args, this.Repository);
                }
                else if (commandName == "Exit")
                {
                    return;
                }
            }
        }
    }
}
