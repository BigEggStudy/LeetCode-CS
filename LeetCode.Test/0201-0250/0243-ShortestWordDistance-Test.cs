using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0243_ShortestWordDistance_Test
    {
        [TestMethod]
        public void ShortestDistance_1()
        {
            var solution = new _0243_ShortestWordDistance();
            var result = solution.ShortestDistance(new string[] { "practice", "makes", "perfect", "coding", "makes" }, "coding", "practice");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ShortestDistance_2()
        {
            var solution = new _0243_ShortestWordDistance();
            var result = solution.ShortestDistance(new string[] { "practice", "makes", "perfect", "coding", "makes" }, "makes", "coding");
            Assert.AreEqual(1, result);
        }
    }
}
