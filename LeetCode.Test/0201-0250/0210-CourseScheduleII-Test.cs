using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0210_CourseScheduleII_Test
    {
        [TestMethod]
        public void CanFinishTest_1()
        {
            var solution = new _0210_CourseSchedule();
            var result = solution.CanFinish(2, new int[][] { new int[] { 1, 0 } });
            AssertHelper.AssertArray(new int[] { 0, 1 }, result);
        }

        [TestMethod]
        public void CanFinishTest_2()
        {
            var solution = new _0210_CourseSchedule();
            var result = solution.CanFinish(2, new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } });
            AssertHelper.AssertArray(new int[] { }, result);
        }

        [TestMethod]
        public void CanFinishTest_3()
        {
            var solution = new _0210_CourseSchedule();
            var result = solution.CanFinish(4, new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 2, 0 },
                new int[] { 3, 1 },
                new int[] { 3, 2 },
            });
            AssertHelper.AssertArray(new int[] { 0, 2, 1, 3 }, result);
        }
    }
}
