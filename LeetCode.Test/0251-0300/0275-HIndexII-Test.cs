using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0275_HIndexII_Test
    {
        [TestMethod]
        public void HIndex_1()
        {
            var solution = new _0275_HIndexII();
            var result = solution.HIndex(new int[] { 0, 1, 3, 5, 6 });
            Assert.AreEqual(3, result);
        }
    }
}
