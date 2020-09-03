using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0967_NumbersWithSameConsecutiveDifferences_Test
    {
        [TestMethod]
        public void NumsSameConsecDiff_1()
        {
            var solution = new _0967_NumbersWithSameConsecutiveDifferences();
            var result = solution.NumsSameConsecDiff(3, 7);
            AssertHelper.AssertArray(new int[] { 181, 292, 707, 818, 929 }, result);
        }

        [TestMethod]
        public void NumsSameConsecDiff_2()
        {
            var solution = new _0967_NumbersWithSameConsecutiveDifferences();
            var result = solution.NumsSameConsecDiff(2, 1);
            AssertHelper.AssertArray(new int[] { 10, 12, 21, 23, 32, 34, 43, 45, 54, 56, 65, 67, 76, 78, 87, 89, 98 }, result);
        }

        [TestMethod]
        public void NumsSameConsecDiff_3()
        {
            var solution = new _0967_NumbersWithSameConsecutiveDifferences();
            var result = solution.NumsSameConsecDiff(1, 1);
            AssertHelper.AssertArray(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, result);
        }

        [TestMethod]
        public void NumsSameConsecDiff_4()
        {
            var solution = new _0967_NumbersWithSameConsecutiveDifferences();
            var result = solution.NumsSameConsecDiff(1, 0);
            AssertHelper.AssertArray(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, result);
        }

        [TestMethod]
        public void NumsSameConsecDiff_5()
        {
            var solution = new _0967_NumbersWithSameConsecutiveDifferences();
            var result = solution.NumsSameConsecDiff(2, 0);
            AssertHelper.AssertArray(new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99 }, result);
        }
    }
}
