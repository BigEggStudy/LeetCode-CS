using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0276_PaintFence_Test
    {
        [TestMethod]
        public void NumWays_1()
        {
            var solution = new _0276_PaintFence();
            var result = solution.NumWays(3, 2);
            Assert.AreEqual(6, result);
        }
    }
}
