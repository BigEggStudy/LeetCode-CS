using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1140_StoneGameII_Test
    {
        [TestMethod]
        public void StoneGameII_1()
        {
            var solution = new _1140_StoneGameII();
            var result = solution.StoneGameII(new int[] { 2, 7, 9, 4, 4 });
            Assert.AreEqual(10, result);
        }
    }
}
