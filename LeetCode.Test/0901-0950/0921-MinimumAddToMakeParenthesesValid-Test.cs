using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0921_MinimumAddToMakeParenthesesValid_Test
    {
        [TestMethod]
        public void MinAddToMakeValid_1()
        {
            var solution = new _0921_MinimumAddToMakeParenthesesValid();
            var result = solution.MinAddToMakeValid("())");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinAddToMakeValid_2()
        {
            var solution = new _0921_MinimumAddToMakeParenthesesValid();
            var result = solution.MinAddToMakeValid("(((");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MinAddToMakeValid_3()
        {
            var solution = new _0921_MinimumAddToMakeParenthesesValid();
            var result = solution.MinAddToMakeValid("()");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MinAddToMakeValid_4()
        {
            var solution = new _0921_MinimumAddToMakeParenthesesValid();
            var result = solution.MinAddToMakeValid("()))((");
            Assert.AreEqual(4, result);
        }
    }
}
