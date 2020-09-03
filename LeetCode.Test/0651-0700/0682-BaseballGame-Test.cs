using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0682_BaseballGame_Test
    {
        [TestMethod]
        public void CalPoints_1()
        {
            var solution = new _0682_BaseballGame();
            var result = solution.CalPoints(new string[] { "5", "2", "C", "D", "+" });
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void CalPoints_2()
        {
            var solution = new _0682_BaseballGame();
            var result = solution.CalPoints(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" });
            Assert.AreEqual(27, result);
        }
    }
}
