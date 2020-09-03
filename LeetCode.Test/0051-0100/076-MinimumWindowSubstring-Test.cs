using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _076_MinimumWindowSubstring_Test
    {
        [TestMethod]
        public void MinWindowTest()
        {
            var solution = new _076_MinimumWindowSubstring();
            var result = solution.MinWindow("ADOBECODEBANC", "ABC");

            Assert.AreEqual("BANC", result);
        }

        [TestMethod]
        public void MinWindowTest_NotContains_Fullly()
        {
            var solution = new _076_MinimumWindowSubstring();
            var result = solution.MinWindow("ADOBECODEBANC", "XYZ");

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void MinWindowTest_SingleCharacterT()
        {
            var solution = new _076_MinimumWindowSubstring();
            var result = solution.MinWindow("ADOBECODEBANC", "A");

            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void MinWindowTest_EmptyT()
        {
            var solution = new _076_MinimumWindowSubstring();
            var result = solution.MinWindow("ADOBECODEBANC", "");

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void MinWindowTest_EmptyS()
        {
            var solution = new _076_MinimumWindowSubstring();
            var result = solution.MinWindow("", "ABC");

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void MinWindowTest_TLongerThanS()
        {
            var solution = new _076_MinimumWindowSubstring();
            var result = solution.MinWindow("AD", "ABC");

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void MinWindowTest_NotContains_Partial()
        {
            var solution = new _076_MinimumWindowSubstring();
            var result = solution.MinWindow("ADOBECODEBANC", "ABX");

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void MinWindowTest_TWithDuplicate()
        {
            var solution = new _076_MinimumWindowSubstring();

            var result = solution.MinWindow("ADOBECODEBANC", "ABCA");
            Assert.AreEqual("ADOBECODEBA", result);

            result = solution.MinWindow("ADOBECODEBANC", "ABCC");
            Assert.AreEqual("CODEBANC", result);
        }
    }
}
