using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1229_MeetingScheduler_Test
    {
        [TestMethod]
        public void MinAvailableDuration_1()
        {
            var solution = new _1229_MeetingScheduler();
            var result = solution.MinAvailableDuration(new int[][] {
                new int[] { 10, 50 },
                new int[] { 60, 120},
                new int[] { 140, 210 },
            }, new int[][] {
                new int[] { 0, 15 },
                new int[] { 60, 70 },
            }, 8);
            AssertHelper.AssertList(new int[] { 60, 68 }, result);
        }

        [TestMethod]
        public void MinAvailableDuration_2()
        {
            var solution = new _1229_MeetingScheduler();
            var result = solution.MinAvailableDuration(new int[][] {
                new int[] { 10, 50 },
                new int[] { 60, 120},
                new int[] { 140, 210 },
            }, new int[][] {
                new int[] { 0, 15 },
                new int[] { 60, 70 },
            }, 12);
            AssertHelper.AssertList(new int[] { }, result);
        }
    }
}
