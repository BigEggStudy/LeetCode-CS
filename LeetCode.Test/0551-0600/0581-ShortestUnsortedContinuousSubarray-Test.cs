using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0581_ShortestUnsortedContinuousSubarray_Test
    {
        [TestMethod]
        public void FindUnsortedSubarray_1()
        {
            var solution = new _0581_ShortestUnsortedContinuousSubarray();
            var result = solution.FindUnsortedSubarray(new int[] { 2, 6, 4, 8, 10, 9, 15 });
            Assert.AreEqual(5, result);
        }
    }
}
