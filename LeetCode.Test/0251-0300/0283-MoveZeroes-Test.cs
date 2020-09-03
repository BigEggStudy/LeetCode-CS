using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0283_MoveZeroes_Test
    {
        [TestMethod]
        public void MoveZeroesTest_Null()
        {
            int[] input = null;

            var solution = new _0283_MoveZeroes();
            solution.MoveZeroes(input);
            Assert.IsNull(input);
        }

        [TestMethod]
        public void MoveZeroesTest_Empty()
        {
            int[] input = new int[0];

            var solution = new _0283_MoveZeroes();
            solution.MoveZeroes(input);
            AssertHelper.AssertArray(new int[0], input);
        }

        [TestMethod]
        public void MoveZeroesTest_1()
        {
            int[] input = new int[] { 0, 1, 0, 3, 12 };

            var solution = new _0283_MoveZeroes();
            solution.MoveZeroes(input);
            AssertHelper.AssertArray(new int[] { 1, 3, 12, 0, 0 }, input);
        }
    }
}
