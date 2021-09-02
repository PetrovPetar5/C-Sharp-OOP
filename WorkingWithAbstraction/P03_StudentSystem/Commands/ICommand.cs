namespace P03_StudentSystem.Commands
{
    using System.Collections.Generic;
    interface ICommand
    {
        void Execute(string[] args, Dictionary<string, Student> repository);
    }
}
