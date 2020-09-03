using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0461_HammingDistance_Test
    {
        [TestMethod]
        public void HammingDistanceTest()
        {
            var solution = new _0461_HammingDistance();
            var result = solution.HammingDistance(1, 4);
            Assert.AreEqual(2, result);
        }
    }
}
