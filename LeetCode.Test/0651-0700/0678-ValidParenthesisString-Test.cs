using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0678_ValidParenthesisString_Test
    {
        [TestMethod]
        public void CheckValidStrin_1()
        {
            var solution = new _0678_ValidParenthesisString();
            var result = solution.CheckValidString("()");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckValidStrin_2()
        {
            var solution = new _0678_ValidParenthesisString();
            var result = solution.CheckValidString("(*)");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckValidStrin_3()
        {
            var solution = new _0678_ValidParenthesisString();
            var result = solution.CheckValidString("(*))");
            Assert.IsTrue(result);
        }
    }
}
