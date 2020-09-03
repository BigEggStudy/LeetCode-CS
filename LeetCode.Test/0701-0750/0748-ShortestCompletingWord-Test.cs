using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0748_ShortestCompletingWord_Test
    {
        [TestMethod]
        public void ShortestCompletingWord_1()
        {
            var solution = new _0748_ShortestCompletingWord();
            var result = solution.ShortestCompletingWord("1s3 PSt", new string[] { "step", "steps", "stripe", "stepple" });
            Assert.AreEqual("steps", result);
        }

        [TestMethod]
        public void ShortestCompletingWord_2()
        {
            var solution = new _0748_ShortestCompletingWord();
            var result = solution.ShortestCompletingWord("1s3 456", new string[] { "looks", "pest", "stew", "show" });
            Assert.AreEqual("pest", result);
        }
    }
}
