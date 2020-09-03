using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1221_SplitAStringInBalancedStrings_Test
    {
        [TestMethod]
        public void BalancedStringSplit_1()
        {
            var solution = new _1221_SplitAStringInBalancedStrings();
            var result = solution.BalancedStringSplit("RLRRLLRLRL");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void BalancedStringSplit_2()
        {
            var solution = new _1221_SplitAStringInBalancedStrings();
            var result = solution.BalancedStringSplit("RLLLLRRRLR");
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void BalancedStringSplit_3()
        {
            var solution = new _1221_SplitAStringInBalancedStrings();
            var result = solution.BalancedStringSplit("LLLLRRRR");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void BalancedStringSplit_4()
        {
            var solution = new _1221_SplitAStringInBalancedStrings();
            var result = solution.BalancedStringSplit("RLRRRLLRLL");
            Assert.AreEqual(2, result);
        }
    }
}
