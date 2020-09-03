using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0888_FairCandySwap_Test
    {
        [TestMethod]
        public void FairCandySwap_1()
        {
            var solution = new _0888_FairCandySwap();
            var result = solution.FairCandySwap(new int[] { 1, 1 }, new int[] { 2, 2 });
            AssertHelper.AssertArray(new int[] { 1, 2 }, result);
        }

        [TestMethod]
        public void FairCandySwap_2()
        {
            var solution = new _0888_FairCandySwap();
            var result = solution.FairCandySwap(new int[] { 1, 2 }, new int[] { 2, 3 });
            AssertHelper.AssertArray(new int[] { 1, 2 }, result);
        }

        [TestMethod]
        public void FairCandySwap_3()
        {
            var solution = new _0888_FairCandySwap();
            var result = solution.FairCandySwap(new int[] { 2 }, new int[] { 1, 3 });
            AssertHelper.AssertArray(new int[] { 2, 3 }, result);
        }

        [TestMethod]
        public void FairCandySwap_4()
        {
            var solution = new _0888_FairCandySwap();
            var result = solution.FairCandySwap(new int[] { 1, 2, 5 }, new int[] { 2, 4 });
            AssertHelper.AssertArray(new int[] { 5, 4 }, result);
        }
    }
}
