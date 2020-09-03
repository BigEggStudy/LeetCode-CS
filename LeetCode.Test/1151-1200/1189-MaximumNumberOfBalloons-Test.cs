using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1189_MaximumNumberOfBalloons_Test
    {
        [TestMethod]
        public void MaxNumberOfBalloons_1()
        {
            var solution = new _1189_MaximumNumberOfBalloons();
            var result = solution.MaxNumberOfBalloons("nlaebolko");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MaxNumberOfBalloons_2()
        {
            var solution = new _1189_MaximumNumberOfBalloons();
            var result = solution.MaxNumberOfBalloons("loonbalxballpoon");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MaxNumberOfBalloons_3()
        {
            var solution = new _1189_MaximumNumberOfBalloons();
            var result = solution.MaxNumberOfBalloons("leetcode");
            Assert.AreEqual(0, result);
        }
    }
}
