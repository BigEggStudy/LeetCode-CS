using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1021_RemoveOutermostParentheses_Test
    {
        [TestMethod]
        public void RemoveOuterParentheses_1()
        {
            var solution = new _1021_RemoveOutermostParentheses();
            var result = solution.RemoveOuterParentheses("(()())(())");
            Assert.AreEqual("()()()", result);
        }

        [TestMethod]
        public void RemoveOuterParentheses_2()
        {
            var solution = new _1021_RemoveOutermostParentheses();
            var result = solution.RemoveOuterParentheses("(()())(())(()(()))");
            Assert.AreEqual("()()()()(())", result);
        }

        [TestMethod]
        public void RemoveOuterParentheses_3()
        {
            var solution = new _1021_RemoveOutermostParentheses();
            var result = solution.RemoveOuterParentheses("()()");
            Assert.AreEqual("", result);
        }
    }
}
