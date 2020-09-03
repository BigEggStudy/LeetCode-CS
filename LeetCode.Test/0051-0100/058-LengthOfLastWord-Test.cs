using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _058_LengthOfLastWord_Test
    {
        [TestMethod]
        public void LengthOfLastWordTestd()
        {
            var solution = new _058_LengthOfLastWord();
            var result = solution.LengthOfLastWord("Hello World");

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void LengthOfLastWordTest_OnlyOneWord()
        {
            var solution = new _058_LengthOfLastWord();
            var result = solution.LengthOfLastWord("Hello");

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void LengthOfLastWordTest_AllSpace()
        {
            var solution = new _058_LengthOfLastWord();
            var result = solution.LengthOfLastWord("    ");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void LengthOfLastWordTest_SpacesAfterLastWord()
        {
            var solution = new _058_LengthOfLastWord();
            var result = solution.LengthOfLastWord("Hello World123    ");

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void LengthOfLastWordTest_EmptyInput()
        {
            var solution = new _058_LengthOfLastWord();
            var result = solution.LengthOfLastWord("");

            Assert.AreEqual(0, result);
        }
    }
}
