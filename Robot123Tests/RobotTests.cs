using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Robot123.Tests
{
    [TestClass()]
    public class RobotTests
    {
        [TestMethod()]
        public void TurnLeftTest()
        {
            Grid grid = new Grid() { X = 3, Y = 3 };

            Robot robot = new Robot()
            {
                X = 1,
                Y = 1,
                Forward = Robot.Direction.North,
                Grid = grid
            };

            robot.TurnLeft();

            Assert.AreEqual(Robot.Direction.West, robot.Forward);
        }

        [TestMethod()]
        public void TurnRightTest()
        {
            Grid grid = new Grid() { X = 3, Y = 3 };

            Robot robot = new Robot()
            {
                X = 1,
                Y = 1,
                Forward = Robot.Direction.North,
                Grid = grid
            };

            robot.TurnRight();

            Assert.AreEqual(Robot.Direction.East, robot.Forward);
        }

        [TestMethod()]
        public void TurnLeftTwiceTest()
        {
            Grid grid = new Grid() { X = 3, Y = 3 };

            Robot robot = new Robot()
            {
                X = 1,
                Y = 1,
                Forward = Robot.Direction.North,
                Grid = grid
            };

            robot.TurnLeft();
            robot.TurnLeft();

            Assert.AreEqual(Robot.Direction.South, robot.Forward);
        }

        [TestMethod()]
        public void MoveForwardTest()
        {
            Grid grid = new Grid() { X = 3, Y = 3 };

            Robot robot = new Robot()
            {
                X = 1,
                Y = 1,
                Forward = Robot.Direction.North,
                Grid = grid
            };

            robot.MoveForward();

            Assert.AreEqual(1, robot.X);
            Assert.AreEqual(2, robot.Y);
            Assert.AreEqual(Robot.Direction.North, robot.Forward);
        }

        [TestMethod()]
        public void MoveTest()
        {
            Grid grid = new Grid() { X = 5, Y = 5 };

            Robot robot = new Robot()
            {
                X = 1,
                Y = 1,
                Forward = Robot.Direction.North,
                Grid = grid
            };

            robot.Move("FFRFLFLF");

            Assert.AreEqual(1, robot.X);
            Assert.AreEqual(4, robot.Y);
            Assert.AreEqual(Robot.Direction.West, robot.Forward);
        }

        [TestMethod()]
        public void MoveTest2()
        {
            Grid grid = new Grid() { X = 5, Y = 5 };

            Robot robot = new Robot()
            {
                X = 1,
                Y = 1,
                Forward = Robot.Direction.North,
                Grid = grid
            };

            robot.Move("FFrfflffrfffllffffflffff");

            Assert.AreEqual(1, robot.X);
            Assert.AreEqual(1, robot.Y);
            Assert.AreEqual(Robot.Direction.South, robot.Forward);
        }

        [TestMethod()]
        public void CannotMovePastBoundaryTest()
        {
            Grid grid = new Grid() { X = 3, Y = 3 };

            Robot robot = new Robot()
            {
                X = 1,
                Y = 1,
                Forward = Robot.Direction.North,
                Grid = grid
            };

            robot.MoveForward();
            robot.MoveForward();
            robot.MoveForward();
            robot.MoveForward();
            robot.MoveForward();

            Assert.AreEqual(1, robot.X);
            Assert.AreEqual(3, robot.Y);
            Assert.AreEqual(Robot.Direction.North, robot.Forward);
        }
    }
}