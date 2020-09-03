using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0316_RemoveDuplicateLetters_Test
    {
        [TestMethod]
        public void RemoveDuplicateLettersTest_1()
        {
            var solution = new _0316_RemoveDuplicateLetters();
            var result = solution.RemoveDuplicateLetters("bcabc");
            Assert.AreEqual("abc", result);
        }

        [TestMethod]
        public void RemoveDuplicateLettersTest_2()
        {
            var solution = new _0316_RemoveDuplicateLetters();
            var result = solution.RemoveDuplicateLetters("cbacdcbc");
            Assert.AreEqual("acdb", result);
        }
    }
}
