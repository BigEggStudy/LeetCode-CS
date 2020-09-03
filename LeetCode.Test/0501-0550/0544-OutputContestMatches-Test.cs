using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0544_OutputContestMatches_Test
    {
        [TestMethod]
        public void FindContestMatch_1()
        {
            var solution = new _0544_OutputContestMatches();
            var result = solution.FindContestMatch(2);
            Assert.AreEqual("(1,2)", result);
        }

        [TestMethod]
        public void FindContestMatch_2()
        {
            var solution = new _0544_OutputContestMatches();
            var result = solution.FindContestMatch(4);
            Assert.AreEqual("((1,4),(2,3))", result);
        }

        [TestMethod]
        public void FindContestMatch_3()
        {
            var solution = new _0544_OutputContestMatches();
            var result = solution.FindContestMatch(8);
            Assert.AreEqual("(((1,8),(4,5)),((2,7),(3,6)))", result);
        }
    }
}
