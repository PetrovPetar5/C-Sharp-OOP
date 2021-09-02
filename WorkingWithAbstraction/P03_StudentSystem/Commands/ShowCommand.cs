namespace P03_StudentSystem.Commands
{
    using P03_StudentSystem.IO;
    using System.Collections.Generic;

    public class ShowCommand : ConsoleWritter, ICommand
    {
        public void Execute(string[] args, Dictionary<string, Student> repository)
        {
            var name = args[1];
            if (repository.ContainsKey(name))
            {
                var student = repository[name];
                this.Write(student.ToString());
            }
        }
    }
}
