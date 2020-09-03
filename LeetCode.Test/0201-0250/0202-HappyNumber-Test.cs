using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0202_HappyNumber_Test
    {
        [TestMethod]
        public void IsHappyTest()
        {
            var solution = new _0202_HappyNumber();
            var result = solution.IsHappy(19);
            Assert.IsTrue(result);
        }
    }
}
