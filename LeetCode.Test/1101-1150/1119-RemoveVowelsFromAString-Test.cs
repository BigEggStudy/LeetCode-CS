using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1119_RemoveVowelsFromAString_Test
    {
        [TestMethod]
        public void RemoveVowelsTest_Empty()
        {
            var solution = new _1119_RemoveVowelsFromAString();
            var result = solution.RemoveVowels("");
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void RemoveVowelsTest_Whitespace()
        {
            var solution = new _1119_RemoveVowelsFromAString();
            var result = solution.RemoveVowels("    ");
            Assert.AreEqual("    ", result);
        }

        [TestMethod]
        public void RemoveVowelsTest_1()
        {
            var solution = new _1119_RemoveVowelsFromAString();
            var result = solution.RemoveVowels("leetcodeisacommunityforcoders");
            Assert.AreEqual("ltcdscmmntyfrcdrs", result);
        }

        [TestMethod]
        public void RemoveVowelsTest_2()
        {
            var solution = new _1119_RemoveVowelsFromAString();
            var result = solution.RemoveVowels("aeiou");
            Assert.AreEqual("", result);
        }
    }
}
