namespace P02_RhombusOfStars
{
    using P02_RhombusOfStars.IO;
    using System;
    using System.Text;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var rhombusSide = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            var writer = new ConsoleWritter();
            DrawRhombus(rhombusSide, sb, writer);
        }

        private static void DrawRhombus(int rhombusSide, StringBuilder sb, IWriter writer)
        {
            DrawUpperRhombusPart(rhombusSide, sb);
            DrawLowerRhombusPart(rhombusSide, sb);
            writer.Write(sb.ToString().TrimEnd());
        }

        private static void DrawUpperRhombusPart(int rhombusSide, StringBuilder sb)
        {
            for (int i = 0; i <= rhombusSide; i++)
            {
                DrawRhombusPart(rhombusSide, sb, i);
            }
        }

        private static void DrawLowerRhombusPart(int rhombusSide, StringBuilder sb)
        {
            for (int i = rhombusSide - 1; i > 0; i--)
            {
                DrawRhombusPart(rhombusSide, sb, i);
            }
        }
        private static void DrawRhombusPart(int rhombusSide, StringBuilder sb, int i)
        {
            sb.Append(new string(' ', rhombusSide - i));
            for (int j = 0; j < i; j++)
            {
                sb.Append("* ");
            }

            sb.AppendLine();
        }
    }
}
