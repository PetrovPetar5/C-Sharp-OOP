namespace P03_StudentSystem.Commands
{
    using P03_StudentSystem.IO;
    using System.Collections.Generic;
    public class CreateCommand : ICommand
    {
        public void Execute(string[] args, Dictionary<string, Student> repository)
        {
            var name = args[1];
            var age = int.Parse(args[2]);
            var grade = double.Parse(args[3]);
            if (!repository.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                repository[name] = student;
            }
        }
    }
}
