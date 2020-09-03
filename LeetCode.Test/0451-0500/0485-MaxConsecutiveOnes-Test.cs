using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0485_MaxConsecutiveOnes_Test
    {
        [TestMethod]
        public void FindMaxConsecutiveOnes_1()
        {
            var solution = new _0485_MaxConsecutiveOnes();
            var result = solution.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });
            Assert.AreEqual(3, result);
        }
    }
}
