using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0403_FrogJump_Test
    {
        [TestMethod]
        public void CanCross_1()
        {
            var solution = new _0403_FrogJump();
            var result = solution.CanCross(new int[] { 0, 1, 3, 5, 6, 8, 12, 17 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanCross_2()
        {
            var solution = new _0403_FrogJump();
            var result = solution.CanCross(new int[] { 0, 1, 2, 3, 4, 8, 9, 11 });
            Assert.IsFalse(result);
        }
    }
}
