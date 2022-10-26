using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Robot123.Tests
{
    [TestClass()]
    public class GridTests
    {
        [TestMethod()]
        public void OutOfBoundaryTest()
        {
            Grid grid = new Grid() { X = 3, Y = 3 };

            Assert.IsTrue(grid.OutOfBoundary(0, 0));
            Assert.IsTrue(grid.OutOfBoundary(0, 1));
            Assert.IsTrue(grid.OutOfBoundary(4, 0));
            Assert.IsTrue(grid.OutOfBoundary(4, 4));
        }

        [TestMethod()]
        public void InsideBoundaryTest()
        {
            Grid grid = new Grid() { X = 3, Y = 3 };

            Assert.IsFalse(grid.OutOfBoundary(1, 1));
            Assert.IsFalse(grid.OutOfBoundary(3, 3));
        }
    }
}