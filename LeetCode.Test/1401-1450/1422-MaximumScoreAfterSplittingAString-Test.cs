using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1422_MaximumScoreAfterSplittingAString_Test
    {
        [TestMethod]
        public void MaxScore_1()
        {
            var solution = new _1422_MaximumScoreAfterSplittingAString();
            var result = solution.MaxScore("011101");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MaxScore_2()
        {
            var solution = new _1422_MaximumScoreAfterSplittingAString();
            var result = solution.MaxScore("00111");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MaxScore_3()
        {
            var solution = new _1422_MaximumScoreAfterSplittingAString();
            var result = solution.MaxScore("1111");
            Assert.AreEqual(3, result);
        }
    }
}
