using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _072_EditDistance_Test
    {
        [TestMethod]
        public void MinDistanceTest_BothEmpty()
        {
            var solution = new _072_EditDistance();
            var result = solution.MinDistance("", "");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MinDistanceTest_OneEmpty_1()
        {
            var solution = new _072_EditDistance();
            var result = solution.MinDistance("", "abc");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MinDistanceTest_OneEmpty_2()
        {
            var solution = new _072_EditDistance();
            var result = solution.MinDistance("abc", "");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MinDistanceTest_Same()
        {
            var solution = new _072_EditDistance();
            var result = solution.MinDistance("abc", "abc");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MinDistanceTest_NotSame()
        {
            var solution = new _072_EditDistance();
            var result = solution.MinDistance("abccb", "abb");

            Assert.AreEqual(2, result);
        }
    }
}
