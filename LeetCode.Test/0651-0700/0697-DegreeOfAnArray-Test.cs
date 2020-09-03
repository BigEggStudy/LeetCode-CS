using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0697_DegreeOfAnArray_Test
    {
        [TestMethod]
        public void FindShortestSubArray_1()
        {
            var solution = new _0697_DegreeOfAnArray();
            var result = solution.FindShortestSubArray(new int[] { 1, 2, 2, 3, 1 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindShortestSubArray_2()
        {
            var solution = new _0697_DegreeOfAnArray();
            var result = solution.FindShortestSubArray(new int[] { 1, 2, 2, 3, 1, 4, 2 });
            Assert.AreEqual(6, result);
        }
    }
}
