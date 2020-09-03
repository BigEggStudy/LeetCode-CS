using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0352_DataStreamAsDisjointIntervals_Test
    {
        [TestMethod]
        public void SummaryRangesTest_1()
        {
            var solution = new _0352_DataStreamAsDisjointIntervals();
            solution.AddNum(1);
            AssertHelper.AssertArray(new int[][] {
                new int[] { 1, 1 },
            }, solution.GetIntervals());

            solution.AddNum(3);
            AssertHelper.AssertArray(new int[][] {
                new int[] { 1, 1 },
                new int[] { 3, 3 },
            }, solution.GetIntervals());

            solution.AddNum(7);
            AssertHelper.AssertArray(new int[][] {
                new int[] { 1, 1 },
                new int[] { 3, 3 },
                new int[] { 7, 7 },
            }, solution.GetIntervals());

            solution.AddNum(2);
            AssertHelper.AssertArray(new int[][] {
                new int[] { 1, 3 },
                new int[] { 7, 7 },
            }, solution.GetIntervals());

            solution.AddNum(6);
            AssertHelper.AssertArray(new int[][] {
                new int[] { 1, 3 },
                new int[] { 6, 7 },
            }, solution.GetIntervals());
        }
    }
}
