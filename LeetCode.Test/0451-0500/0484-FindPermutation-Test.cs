using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0484_FindPermutation_Test
    {
        [TestMethod]
        public void FindPermutation_1()
        {
            var solution = new _0484_FindPermutation();
            var result = solution.FindPermutation("I");
            AssertHelper.AssertArray(new int[] { 1, 2 }, result);
        }

        [TestMethod]
        public void FindPermutation_2()
        {
            var solution = new _0484_FindPermutation();
            var result = solution.FindPermutation("DI");
            AssertHelper.AssertArray(new int[] { 2, 1, 3 }, result);
        }

        [TestMethod]
        public void FindPermutation_3()
        {
            var solution = new _0484_FindPermutation();
            var result = solution.FindPermutation("DDIIDI");
            AssertHelper.AssertArray(new int[] { 3, 2, 1, 4, 6, 5, 7 }, result);
        }
    }
}
