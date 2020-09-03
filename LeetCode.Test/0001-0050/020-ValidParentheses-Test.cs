using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _020_ValidParentheses_Test
    {
        [TestMethod]
        public void IsValidTest()
        {
            var solution = new _020_ValidParentheses();

            Assert.IsTrue(solution.IsValid("()"));
            Assert.IsTrue(solution.IsValid("[]"));
            Assert.IsTrue(solution.IsValid("{}"));
            Assert.IsTrue(solution.IsValid("()[]{}"));
        }

        [TestMethod]
        public void IsValidTest_WithOtherCharacters()
        {
            var solution = new _020_ValidParentheses();

            Assert.IsTrue(solution.IsValid("abc(abc)abc"));
            Assert.IsTrue(solution.IsValid("abc[abc]abc"));
            Assert.IsTrue(solution.IsValid("abc{abc}abc"));
            Assert.IsTrue(solution.IsValid("abc(abc)abc[abc]abc{abc}abc"));
        }

        [TestMethod]
        public void IsValidTest_NotValid()
        {
            var solution = new _020_ValidParentheses();

            Assert.IsFalse(solution.IsValid("("));
            Assert.IsFalse(solution.IsValid(")"));
            Assert.IsFalse(solution.IsValid("["));
            Assert.IsFalse(solution.IsValid("]"));
            Assert.IsFalse(solution.IsValid("{"));
            Assert.IsFalse(solution.IsValid("}"));
            Assert.IsFalse(solution.IsValid("(]"));
            Assert.IsFalse(solution.IsValid("(}"));
            Assert.IsFalse(solution.IsValid("[)"));
            Assert.IsFalse(solution.IsValid("[}"));
            Assert.IsFalse(solution.IsValid("{)"));
            Assert.IsFalse(solution.IsValid("{]"));
        }
    }
}
