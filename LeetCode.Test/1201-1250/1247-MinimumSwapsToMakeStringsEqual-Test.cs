using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1247_MinimumSwapsToMakeStringsEqual_Test
    {
        [TestMethod]
        public void MinimumSwap_1()
        {
            var solution = new _1247_MinimumSwapsToMakeStringsEqual();
            var result = solution.MinimumSwap("xx", "yy");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinimumSwap_2()
        {
            var solution = new _1247_MinimumSwapsToMakeStringsEqual();
            var result = solution.MinimumSwap("xy", "yx");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinimumSwap_3()
        {
            var solution = new _1247_MinimumSwapsToMakeStringsEqual();
            var result = solution.MinimumSwap("xx", "xy");
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void MinimumSwap_4()
        {
            var solution = new _1247_MinimumSwapsToMakeStringsEqual();
            var result = solution.MinimumSwap("xxyyxyxyxx", "xyyxyxxxyx");
            Assert.AreEqual(4, result);
        }
    }
}
