using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0727_MinimumWindowSubsequence_Test
    {
        [TestMethod]
        public void MinWindowTest_1()
        {
            var solution = new _0727_MinimumWindowSubsequence();
            var result = solution.MinWindow("abcdebdde", "bde");
            Assert.AreEqual("bcde", result);
        }

        [TestMethod]
        public void MinWindowTest_2()
        {
            var solution = new _0727_MinimumWindowSubsequence();
            var result = solution.MinWindow("jmeqksfrsdcmsiwvaovztaqenprpvnbstl", "l");
            Assert.AreEqual("l", result);
        }
    }
}
