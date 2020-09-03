using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0345_ReverseVowelsOfAString_Test
    {
        [TestMethod]
        public void ReverseVowels_1()
        {
            var solution = new _0345_ReverseVowelsOfAString();
            var result = solution.ReverseVowels("hello");
            Assert.AreEqual("holle", result);
        }

        [TestMethod]
        public void ReverseVowels_2()
        {
            var solution = new _0345_ReverseVowelsOfAString();
            var result = solution.ReverseVowels("leetcode");
            Assert.AreEqual("leotcede", result);
        }

        [TestMethod]
        public void ReverseVowels_3()
        {
            var solution = new _0345_ReverseVowelsOfAString();
            var result = solution.ReverseVowels("Aa");
            Assert.AreEqual("aA", result);
        }

        [TestMethod]
        public void ReverseVowels_4()
        {
            var solution = new _0345_ReverseVowelsOfAString();
            var result = solution.ReverseVowels(".,");
            Assert.AreEqual(".,", result);
        }
    }
}
