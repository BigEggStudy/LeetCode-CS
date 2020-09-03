using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0347_TopKFrequentElements_Test
    {
        [TestMethod]
        public void TopKFrequentTest_1()
        {
            var solution = new _0347_TopKFrequentElements();
            var result = solution.TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
            AssertHelper.AssertList(new int[] { 1, 2 }, result);
        }
    }
}
