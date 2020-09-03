using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0520_DetectCapital_Test
    {
        [TestMethod]
        public void DetectCapitalUse_1()
        {
            var solution = new _0520_DetectCapital();
            var result = solution.DetectCapitalUse("USA");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DetectCapitalUse_2()
        {
            var solution = new _0520_DetectCapital();
            var result = solution.DetectCapitalUse("FlaG");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DetectCapitalUse_3()
        {
            var solution = new _0520_DetectCapital();
            var result = solution.DetectCapitalUse("leetcode");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DetectCapitalUse_4()
        {
            var solution = new _0520_DetectCapital();
            var result = solution.DetectCapitalUse("Google");
            Assert.IsTrue(result);
        }
    }
}
