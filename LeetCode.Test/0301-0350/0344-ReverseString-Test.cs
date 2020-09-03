using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0344_ReverseString_Test
    {
        [TestMethod]
        public void ReverseStringTest_1()
        {
            var input = new char[] { 'h', 'e', 'l', 'l', 'o' };

            var solution = new _0344_ReverseString();
            solution.ReverseString(input);
            AssertHelper.AssertArray(new char[] { 'o', 'l', 'l', 'e', 'h' }, input);
        }

        [TestMethod]
        public void ReverseStringTest_2()
        {
            var input = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };

            var solution = new _0344_ReverseString();
            solution.ReverseString(input);
            AssertHelper.AssertArray(new char[] { 'h', 'a', 'n', 'n', 'a', 'H' }, input);
        }
    }
}
