using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0832_FlippingAnImage_Test
    {
        [TestMethod]
        public void FlipAndInvertImage_1()
        {
            var solution = new _0832_FlippingAnImage();
            var result = solution.FlipAndInvertImage(new int[][]
                {
                    new int[] { 1, 1, 0 },
                    new int[] { 1, 0, 1 },
                    new int[] { 0, 0, 0 },
                });
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 1, 0 ,0 },
                    new int[] { 0, 1, 0 },
                    new int[] { 1, 1, 1 },
                }, result);
        }

        [TestMethod]
        public void FlipAndInvertImage_2()
        {
            var solution = new _0832_FlippingAnImage();
            var result = solution.FlipAndInvertImage(new int[][]
                {
                    new int[] { 1, 1, 0, 0 },
                    new int[] { 1, 0, 0, 1 },
                    new int[] { 0, 1, 1, 1 },
                    new int[] { 1, 0, 1, 0 },
                });
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 1, 1, 0, 0 },
                    new int[] { 0, 1, 1, 0 },
                    new int[] { 0, 0, 0, 1 },
                    new int[] { 1, 0, 1, 0 },
                }, result);
        }
    }
}
