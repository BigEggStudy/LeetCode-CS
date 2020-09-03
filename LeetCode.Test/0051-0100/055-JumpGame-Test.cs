using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _055_JumpGame_Test
    {
        [TestMethod]
        public void CanJumpTest_Can()
        {
            var input = new int[] { 2, 3, 1, 1, 4 };

            var solution = new _055_JumpGame();
            Assert.IsTrue(solution.CanJump(input));
        }

        [TestMethod]
        public void CanJumpTest_Can_2()
        {
            var input = new int[] { 7, 0, 9, 6, 9, 6, 1, 7, 9, 0, 1, 2, 9, 0, 3 };

            var solution = new _055_JumpGame();
            Assert.IsTrue(solution.CanJump(input));
        }

        [TestMethod]
        public void CanJumpTest_OneItem()
        {
            var input = new int[] { 0 };

            var solution = new _055_JumpGame();
            Assert.IsTrue(solution.CanJump(input));
        }

        [TestMethod]
        public void CanJumpTest_OneItem_2()
        {
            var input = new int[] { 1 };

            var solution = new _055_JumpGame();
            Assert.IsTrue(solution.CanJump(input));
        }

        [TestMethod]
        public void CanJumpTest_Cannot()
        {
            var input = new int[] { 0, 1 };

            var solution = new _055_JumpGame();
            Assert.IsFalse(solution.CanJump(input));
        }

        [TestMethod]
        public void CanJumpTest_Cannot_2()
        {
            var input = new int[] { 3, 2, 1, 0, 4 };

            var solution = new _055_JumpGame();
            Assert.IsFalse(solution.CanJump(input));
        }
    }
}
