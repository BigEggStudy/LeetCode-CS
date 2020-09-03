using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1318_MinimumFlipsToMakeAORBEqualToC_Test
    {
        [TestMethod]
        public void MinFlips_1()
        {
            var solution = new _1318_MinimumFlipsToMakeAORBEqualToC();
            var result = solution.MinFlips(2, 6, 5);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MinFlips_2()
        {
            var solution = new _1318_MinimumFlipsToMakeAORBEqualToC();
            var result = solution.MinFlips(4, 2, 7);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinFlips_3()
        {
            var solution = new _1318_MinimumFlipsToMakeAORBEqualToC();
            var result = solution.MinFlips(1, 2, 3);
            Assert.AreEqual(0, result);
        }
    }
}
