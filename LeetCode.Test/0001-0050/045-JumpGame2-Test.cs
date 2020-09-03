using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _045_JumpGame2_Test
    {
        [TestMethod]
        public void JumpTest()
        {
            var input = new int[] { 2, 3, 1, 1, 4 };

            var solution = new _045_JumpGame2();
            var result = solution.Jump(input);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void JumpTest_2()
        {
            var input = new int[] { 7, 0, 9, 6, 9, 6, 1, 7, 9, 0, 1, 2, 9, 0, 3 };

            var solution = new _045_JumpGame2();
            var result = solution.Jump(input);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void JumpTest_OneItem()
        {
            var input = new int[] { 0 };

            var solution = new _045_JumpGame2();
            var result = solution.Jump(input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void JumpTest_OneItem_2()
        {
            var input = new int[] { 1 };

            var solution = new _045_JumpGame2();
            var result = solution.Jump(input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void JumpTest_NotReached()
        {
            var input = new int[] { 0, 1 };

            var solution = new _045_JumpGame2();
            var result = solution.Jump(input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void JumpTest_NotReached_2()
        {
            var input = new int[] { 3, 2, 1, 0, 5 };

            var solution = new _045_JumpGame2();
            var result = solution.Jump(input);

            Assert.AreEqual(0, result);
        }
    }
}
