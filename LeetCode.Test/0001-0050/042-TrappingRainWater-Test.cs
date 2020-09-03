using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _042_TrappingRainWater_Test
    {
        [TestMethod]
        public void TrapTest()
        {
            var input = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            var solution = new _042_TrappingRainWater();
            var result = solution.Trap(input);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TrapTest_Balance()
        {
            var input = new int[] { 2, 0, 2 };

            var solution = new _042_TrappingRainWater();
            var result = solution.Trap(input);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TrapTest_FirstOneHigher()
        {
            var input = new int[] { 2, 1, 0, 1, 0, 1, 0, 1, 0, 1 };

            var solution = new _042_TrappingRainWater();
            var result = solution.Trap(input);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TrapTest_LastOneHigher()
        {
            var input = new int[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 2 };

            var solution = new _042_TrappingRainWater();
            var result = solution.Trap(input);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TrapTest_Higher()
        {
            var input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            var solution = new _042_TrappingRainWater();
            var result = solution.Trap(input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TrapTest_Lower()
        {
            var input = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            var solution = new _042_TrappingRainWater();
            var result = solution.Trap(input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TrapTest_EmptyInput()
        {
            var solution = new _042_TrappingRainWater();
            var result = solution.Trap(new int[] { });

            Assert.AreEqual(0, result);
        }
    }
}
