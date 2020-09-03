using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1427_PerformStringShifts_Test
    {
        [TestMethod]
        public void StringShiftTest_1()
        {
            var solution = new _1427_PerformStringShifts();
            var result = solution.StringShift("abc", new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 } });
            Assert.AreEqual("cab", result);
        }

        [TestMethod]
        public void StringShiftTest_2()
        {
            var solution = new _1427_PerformStringShifts();
            var result = solution.StringShift("abcdefg", new int[][] {
                new int[] { 1, 1 },
                new int[] { 1, 1 },
                new int[] { 0, 2 },
                new int[] { 1, 3 }
            });
            Assert.AreEqual("efgabcd", result);
        }

        [TestMethod]
        public void StringShiftTest_3()
        {
            var solution = new _1427_PerformStringShifts();
            var result = solution.StringShift("abc", new int[][] { new int[] { 0, 1 } });
            Assert.AreEqual("bca", result);
        }

        [TestMethod]
        public void StringShiftTest_4()
        {
            var solution = new _1427_PerformStringShifts();
            var result = solution.StringShift("abcdefg", new int[][] {
                new int[] { 1, 1 },
                new int[] { 1, 1 },
                new int[] { 0, 2 },
            });
            Assert.AreEqual("abcdefg", result);
        }
    }
}
