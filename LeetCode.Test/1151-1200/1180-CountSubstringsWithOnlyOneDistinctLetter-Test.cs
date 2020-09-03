using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1180_CountSubstringsWithOnlyOneDistinctLetter_Test
    {
        [TestMethod]
        public void CountLetters_1()
        {
            var solution = new _1180_CountSubstringsWithOnlyOneDistinctLetter();
            var result = solution.CountLetters("aaaba");
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void CountLetters_2()
        {
            var solution = new _1180_CountSubstringsWithOnlyOneDistinctLetter();
            var result = solution.CountLetters("aaaaaaaaaa");
            Assert.AreEqual(55, result);
        }
    }
}
