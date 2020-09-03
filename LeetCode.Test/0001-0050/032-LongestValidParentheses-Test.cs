using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _032_LongestValidParentheses_Test
    {
        [TestMethod]
        public void LongestValidParenthesesTest()
        {
            var solution = new _032_LongestValidParentheses();
            var result = solution.LongestValidParentheses("()");
            Assert.AreEqual(2, result);

            result = solution.LongestValidParentheses("(()())");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void LongestValidParenthesesTest_HaveError()
        {
            var solution = new _032_LongestValidParentheses();
            var result = solution.LongestValidParentheses(")()");
            Assert.AreEqual(2, result);

            result = solution.LongestValidParentheses("(()");
            Assert.AreEqual(2, result);

            result = solution.LongestValidParentheses(")()())");
            Assert.AreEqual(4, result);

            result = solution.LongestValidParentheses("(()()(");
            Assert.AreEqual(4, result);
        }
    }
}
