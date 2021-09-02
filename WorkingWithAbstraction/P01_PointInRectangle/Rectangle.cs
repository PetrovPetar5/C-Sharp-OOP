namespace P01_PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
        public Point TopLeft { get; private set; }
        public Point BottomRight { get; private set; }

        public bool Contains(Point point)
        {
            var isValidX = point.X >= this.TopLeft.X && point.X <= this.BottomRight.X;
            var isValidY = point.Y >= this.TopLeft.Y && point.Y <= this.BottomRight.Y;
            return isValidX && isValidY;
        }
    }
}
