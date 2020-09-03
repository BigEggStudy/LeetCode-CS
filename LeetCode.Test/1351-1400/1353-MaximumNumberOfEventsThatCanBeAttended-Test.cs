using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1353_MaximumNumberOfEventsThatCanBeAttended_Test
    {
        [TestMethod]
        public void MaxEvents_1()
        {
            var solution = new _1353_MaximumNumberOfEventsThatCanBeAttended();
            var result = solution.MaxEvents(new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
            });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MaxEvents_2()
        {
            var solution = new _1353_MaximumNumberOfEventsThatCanBeAttended();
            var result = solution.MaxEvents(new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 1, 2 },
            });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaxEvents_3()
        {
            var solution = new _1353_MaximumNumberOfEventsThatCanBeAttended();
            var result = solution.MaxEvents(new int[][] {
                new int[] { 1, 4 },
                new int[] { 4, 4 },
                new int[] { 2, 2 },
                new int[] { 3, 4 },
                new int[] { 1, 1 },
            });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaxEvents_4()
        {
            var solution = new _1353_MaximumNumberOfEventsThatCanBeAttended();
            var result = solution.MaxEvents(new int[][] {
                new int[] { 1, 100000 },
            });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MaxEvents_5()
        {
            var solution = new _1353_MaximumNumberOfEventsThatCanBeAttended();
            var result = solution.MaxEvents(new int[][] {
                new int[] { 1, 1 },
                new int[] { 1, 2 },
                new int[] { 1, 3 },
                new int[] { 1, 4 },
                new int[] { 1, 5 },
                new int[] { 1, 6 },
                new int[] { 1, 7 },
            });
            Assert.AreEqual(7, result);
        }
    }
}
