namespace P01_PointInRectangle
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            var rectangleCoordinates = Console.ReadLine().Split();
            var rectangle = GetRectangle(rectangleCoordinates);
            var n = long.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var curCoordinates = Console.ReadLine().Split();
                Point curPoint = GetCoordinatePoint(curCoordinates);
                Console.WriteLine(rectangle.Contains(curPoint));
            }
        }

        private static Point GetCoordinatePoint(string[] curCoordinates)
        {
            var curX = int.Parse(curCoordinates[0]);
            var curY = int.Parse(curCoordinates[1]);
            var curPoint = new Point(curX, curY);
            return curPoint;
        }

        private static Point GetCoordinatePoint(int x, int y)
        {
            var curPoint = new Point(x, y);
            return curPoint;
        }

        private static Rectangle GetRectangle(string[] rectangleCoordinates)
        {
            var topLeftX = int.Parse(rectangleCoordinates[0]);
            var topLeftY = int.Parse(rectangleCoordinates[1]);
            var bottomRightX = int.Parse(rectangleCoordinates[2]);
            var bottomRightY = int.Parse(rectangleCoordinates[3]);

            var topLeftPoint = GetCoordinatePoint(topLeftX, topLeftY);
            var bottomRightPoint = GetCoordinatePoint(bottomRightX, bottomRightY);
            var rectangle = new Rectangle(topLeftPoint, bottomRightPoint);
            return rectangle;
        }
    }
}
