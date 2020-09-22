using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1094_CarPooling_Test
    {
        [TestMethod]
        public void CarPooling_1()
        {
            var solution = new _1094_CarPooling();
            var result = solution.CarPooling(new int[][] {
                new int[] { 2, 1, 5 },
                new int[] { 3, 3, 7 },
            }, 4);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CarPooling_2()
        {
            var solution = new _1094_CarPooling();
            var result = solution.CarPooling(new int[][] {
                new int[] { 2, 1, 5 },
                new int[] { 3, 3, 7 },
            }, 5);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CarPooling_3()
        {
            var solution = new _1094_CarPooling();
            var result = solution.CarPooling(new int[][] {
                new int[] { 2, 1, 5 },
                new int[] { 3, 5, 7 },
            }, 3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CarPooling_4()
        {
            var solution = new _1094_CarPooling();
            var result = solution.CarPooling(new int[][] {
                new int[] { 3, 2, 7 },
                new int[] { 3, 7, 9 },
                new int[] { 8, 3, 9 },
            }, 11);
            Assert.IsTrue(result);
        }
    }
}
