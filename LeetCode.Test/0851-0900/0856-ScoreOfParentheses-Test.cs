using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0856_ScoreOfParentheses_Test
    {
        [TestMethod]
        public void ScoreOfParentheses_1()
        {
            var solution = new _0856_ScoreOfParentheses();
            var result = solution.ScoreOfParentheses("()");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ScoreOfParentheses_2()
        {
            var solution = new _0856_ScoreOfParentheses();
            var result = solution.ScoreOfParentheses("(())");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ScoreOfParentheses_3()
        {
            var solution = new _0856_ScoreOfParentheses();
            var result = solution.ScoreOfParentheses("()()");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ScoreOfParentheses_4()
        {
            var solution = new _0856_ScoreOfParentheses();
            var result = solution.ScoreOfParentheses("(()(()))");
            Assert.AreEqual(6, result);
        }
    }
}
