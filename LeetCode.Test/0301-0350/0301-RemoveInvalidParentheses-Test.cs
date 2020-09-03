using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0301_RemoveInvalidParentheses_Test
    {
        [TestMethod]
        public void RemoveInvalidParenthesesTest_1()
        {
            var solution = new _0301_RemoveInvalidParentheses();
            var result = solution.RemoveInvalidParentheses("()())()");
            AssertHelper.AssertList(new string[] { "(())()", "()()()" }, result);
        }

        [TestMethod]
        public void RemoveInvalidParenthesesTest_2()
        {
            var solution = new _0301_RemoveInvalidParentheses();
            var result = solution.RemoveInvalidParentheses("(a)())()");
            AssertHelper.AssertList(new string[] { "(a())()", "(a)()()" }, result);
        }

        [TestMethod]
        public void RemoveInvalidParenthesesTest_3()
        {
            var solution = new _0301_RemoveInvalidParentheses();
            var result = solution.RemoveInvalidParentheses(")(");
            AssertHelper.AssertList(new string[] { "" }, result);
        }
    }
}
