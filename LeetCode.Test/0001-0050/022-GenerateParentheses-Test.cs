using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _022_GenerateParentheses_Test
    {
        [TestMethod]
        public void GenerateParenthesisTest()
        {
            var solution = new _022_GenerateParentheses();
            var result = solution.GenerateParenthesis(3);

            Assert.AreEqual(5, result.Count);
            Assert.AreEqual("((()))", result[0]);
            Assert.AreEqual("(()())", result[1]);
            Assert.AreEqual("(())()", result[2]);
            Assert.AreEqual("()(())", result[3]);
            Assert.AreEqual("()()()", result[4]);
        }

        [TestMethod]
        public void GenerateParenthesisTest_NLessThanZero()
        {
            var solution = new _022_GenerateParentheses();
            var result = solution.GenerateParenthesis(-1);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GenerateParenthesisTest_NEqualZero()
        {
            var solution = new _022_GenerateParentheses();
            var result = solution.GenerateParenthesis(0);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GenerateParenthesisTest_NEqualOne()
        {
            var solution = new _022_GenerateParentheses();
            var result = solution.GenerateParenthesis(1);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("()", result[0]);
        }

        [TestMethod]
        public void GenerateParenthesisTest_LargeN()
        {
            var solution = new _022_GenerateParentheses();
            var result = solution.GenerateParenthesis(4);
            Assert.AreEqual(14, result.Count);
            result = solution.GenerateParenthesis(5);
            Assert.AreEqual(42, result.Count);
            result = solution.GenerateParenthesis(6);
            Assert.AreEqual(132, result.Count);
        }
    }
}
