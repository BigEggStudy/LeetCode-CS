using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1249_MinimumRemoveToMakeValidParentheses_Test
    {
        [TestMethod]
        public void MinRemoveToMakeValid_1()
        {
            var solution = new _1249_MinimumRemoveToMakeValidParentheses();
            var result = solution.MinRemoveToMakeValid("lee(t(c)o)de)");
            Assert.AreEqual("lee(t(c)o)de", result);
        }

        [TestMethod]
        public void MinRemoveToMakeValid_2()
        {
            var solution = new _1249_MinimumRemoveToMakeValidParentheses();
            var result = solution.MinRemoveToMakeValid("a)b(c)d");
            Assert.AreEqual("ab(c)d", result);
        }

        [TestMethod]
        public void MinRemoveToMakeValid_3()
        {
            var solution = new _1249_MinimumRemoveToMakeValidParentheses();
            var result = solution.MinRemoveToMakeValid("))((");
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void MinRemoveToMakeValid_4()
        {
            var solution = new _1249_MinimumRemoveToMakeValidParentheses();
            var result = solution.MinRemoveToMakeValid("(a(b(c)d)");
            Assert.AreEqual("a(b(c)d)", result);
        }
    }
}
