using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0594_LongestHarmoniousSubsequence_Test
    {
        [TestMethod]
        public void FindLHS_1()
        {
            var solution = new _0594_LongestHarmoniousSubsequence();
            var result = solution.FindLHS(new int[] { 1, 3, 2, 2, 5, 2, 3, 7 });
            Assert.AreEqual(5, result);
        }
    }
}
