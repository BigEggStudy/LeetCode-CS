using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0819_MostCommonWord_Test
    {
        [TestMethod]
        public void MostCommonWord_1()
        {
            var solution = new _0819_MostCommonWord();
            var result = solution.MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" });
            Assert.AreEqual("ball", result);
        }

        [TestMethod]
        public void MostCommonWord_2()
        {
            var solution = new _0819_MostCommonWord();
            var result = solution.MostCommonWord("a, a, a, a, b,b,b,c, c", new string[] { "a" });
            Assert.AreEqual("b", result);
        }
    }
}
