namespace Robot123
{
    public class Grid
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool OutOfBoundary(int x, int y)
        {
            if (x < 1 || x > X || y < 1 || y > Y)
                return true;

            return false;
        }
    }
}
