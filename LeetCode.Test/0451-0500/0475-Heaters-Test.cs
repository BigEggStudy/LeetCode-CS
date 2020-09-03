using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0475_Heaters_Test
    {
        [TestMethod]
        public void FindRadius_1()
        {
            var solution = new _0475_Heaters();
            var result = solution.FindRadius(new int[] { 1, 2, 3 }, new int[] { 2 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindRadius_2()
        {
            var solution = new _0475_Heaters();
            var result = solution.FindRadius(new int[] { 1, 2, 3, 4 }, new int[] { 1, 4 });
            Assert.AreEqual(1, result);
        }
    }
}
