using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0198_HouseRobber_Test
    {
        [TestMethod]
        public void RobTest_1()
        {
            var solution = new _0198_HouseRobber();
            var result = solution.Rob(new int[] { 1, 2, 3, 1 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void RobTest_2()
        {
            var solution = new _0198_HouseRobber();
            var result = solution.Rob(new int[] { 2, 7, 9, 3, 1 });
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void RobTest_3()
        {
            var solution = new _0198_HouseRobber();
            var result = solution.Rob(new int[] { 2, 7, 3, 1, 9 });
            Assert.AreEqual(16, result);
        }
    }
}
