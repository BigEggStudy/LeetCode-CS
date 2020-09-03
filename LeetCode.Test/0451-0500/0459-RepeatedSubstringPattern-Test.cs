using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0459_RepeatedSubstringPattern_Test
    {
        [TestMethod]
        public void RepeatedSubstringPattern_1()
        {
            var solution = new _0459_RepeatedSubstringPattern();
            var result = solution.RepeatedSubstringPattern("abab");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RepeatedSubstringPattern_2()
        {
            var solution = new _0459_RepeatedSubstringPattern();
            var result = solution.RepeatedSubstringPattern("aba");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RepeatedSubstringPattern_3()
        {
            var solution = new _0459_RepeatedSubstringPattern();
            var result = solution.RepeatedSubstringPattern("abcabcabcabc");
            Assert.IsTrue(result);
        }
    }
}
