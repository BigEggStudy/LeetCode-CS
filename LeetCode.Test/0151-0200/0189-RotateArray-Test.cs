using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0189_RotateArray_Test
    {
        [TestMethod]
        public void Rotate_1()
        {
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var solution = new _0189_RotateArray();
            solution.Rotate(input, 3);
            AssertHelper.AssertArray(new int[] { 5, 6, 7, 1, 2, 3, 4 }, input);
        }

        [TestMethod]
        public void Rotate_2()
        {
            var input = new int[] { -1, -100, 3, 99 };

            var solution = new _0189_RotateArray();
            solution.Rotate(input, 2);
            AssertHelper.AssertArray(new int[] { 3, 99, -1, -100 }, input);
        }
    }
}
