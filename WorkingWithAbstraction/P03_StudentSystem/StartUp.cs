namespace P03_StudentSystem
{
    using P03_StudentSystem.IO;
    public class StartUp
    {
        static void Main()
        {
            var studentData = new StudentData();
            studentData.ParseCommand(new ConsoleReader());
        }
    }
}
