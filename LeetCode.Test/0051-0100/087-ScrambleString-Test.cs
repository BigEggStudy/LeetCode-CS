using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _087_ScrambleString_Test
    {
        [TestMethod]
        public void IsScrambleTest_Odd()
        {
            var solution = new _087_ScrambleString();
            Assert.IsTrue(solution.IsScramble("great", "rgeat"));
            Assert.IsTrue(solution.IsScramble("rgeat", "great"));
            Assert.IsTrue(solution.IsScramble("great", "rgtae"));
            Assert.IsTrue(solution.IsScramble("rgeat", "rgtae"));
        }

        [TestMethod]
        public void IsScrambleTest_Even()
        {
            var solution = new _087_ScrambleString();
            Assert.IsTrue(solution.IsScramble("abab", "baba"));
            Assert.IsTrue(solution.IsScramble("abcd", "bcad"));
        }

        [TestMethod]
        public void IsScrambleTest_Same()
        {
            var solution = new _087_ScrambleString();
            Assert.IsTrue(solution.IsScramble("ab", "ab"));
        }

        [TestMethod]
        public void IsScrambleTest_Not()
        {
            var solution = new _087_ScrambleString();
            Assert.IsFalse(solution.IsScramble("abcde", "caebd"));
        }
    }
}
