using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0703_KthLargestElementInAStream_Test
    {
        [TestMethod]
        public void KthLargestTest_1()
        {
            int k = 3;
            int[] arr = new int[] { 4, 5, 8, 2 };

            var solution = new _0703_KthLargestElementInAStream(k, arr);
            Assert.AreEqual(4, solution.Add(3));
            Assert.AreEqual(5, solution.Add(5));
            Assert.AreEqual(5, solution.Add(10));
            Assert.AreEqual(8, solution.Add(9));
            Assert.AreEqual(8, solution.Add(4));
        }
    }
}
