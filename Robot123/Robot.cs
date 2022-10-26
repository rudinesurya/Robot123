using System.Diagnostics.Contracts;

namespace Robot123
{
    public class Robot
    {
        public enum Direction { North, East, South, West };

        public int X { get; set; }
        public int Y { get; set; }
        public Direction Forward { get; set; }
        public Grid Grid { get; set; }

        public void Move(string moveSet)
        {
            for (int i = 0; i < moveSet.Length; ++i)
            {
                switch (char.ToUpper(moveSet[i]))
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'F':
                        MoveForward();
                        break;
                }
            }
        }

        public void TurnLeft()
        {
            Forward = (Direction)(((int)Forward - 1 + 4) % 4);
        }

        public void TurnRight()
        {
            Forward = (Direction)(((int)Forward + 1 + 4) % 4);
        }

        public void MoveForward()
        {
            switch (Forward)
            {
                case Direction.North:
                    if (!Grid.OutOfBoundary(X, Y + 1))
                        ++Y;
                    break;
                case Direction.East:
                    if (!Grid.OutOfBoundary(X + 1, Y))
                        ++X;
                    break;
                case Direction.South:
                    if (!Grid.OutOfBoundary(X, Y - 1))
                        --Y;
                    break;
                case Direction.West:
                    if (!Grid.OutOfBoundary(X - 1, Y))
                        --X;
                    break;
            }
        }
    }
}
