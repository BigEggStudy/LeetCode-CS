using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1190_ReverseSubstringsBetweenEachPairOfParentheses_Test
    {
        [TestMethod]
        public void ReverseParentheses_1()
        {
            var solution = new _1190_ReverseSubstringsBetweenEachPairOfParentheses();
            var result = solution.ReverseParentheses("(abcd)");
            Assert.AreEqual("dcba", result);
        }

        [TestMethod]
        public void ReverseParentheses_2()
        {
            var solution = new _1190_ReverseSubstringsBetweenEachPairOfParentheses();
            var result = solution.ReverseParentheses("(u(love)i)");
            Assert.AreEqual("iloveu", result);
        }

        [TestMethod]
        public void ReverseParentheses_3()
        {
            var solution = new _1190_ReverseSubstringsBetweenEachPairOfParentheses();
            var result = solution.ReverseParentheses("(ed(et(oc))el)");
            Assert.AreEqual("leetcode", result);
        }

        [TestMethod]
        public void ReverseParentheses_4()
        {
            var solution = new _1190_ReverseSubstringsBetweenEachPairOfParentheses();
            var result = solution.ReverseParentheses("a(bcdefghijkl(mno)p)q");
            Assert.AreEqual("apmnolkjihgfedcbq", result);
        }
    }
}
