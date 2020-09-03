using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1037_ValidBoomerang_Test
    {
        [TestMethod]
        public void IsBoomerang_1()
        {
            var solution = new _1037_ValidBoomerang();
            var result = solution.IsBoomerang(new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 2 },
            });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsBoomerang_2()
        {
            var solution = new _1037_ValidBoomerang();
            var result = solution.IsBoomerang(new int[][] {
                new int[] { 1, 1 },
                new int[] { 2, 2 },
                new int[] { 3, 3 },
            });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsBoomerang_3()
        {
            var solution = new _1037_ValidBoomerang();
            var result = solution.IsBoomerang(new int[][] {
                new int[] { 0, 1 },
                new int[] { 0, 1 },
                new int[] { 2, 1 },
            });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsBoomerang_4()
        {
            var solution = new _1037_ValidBoomerang();
            var result = solution.IsBoomerang(new int[][] {
                new int[] { 1, 0 },
                new int[] { 1, 0 },
                new int[] { 1, 2 },
            });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsBoomerang_5()
        {
            var solution = new _1037_ValidBoomerang();
            var result = solution.IsBoomerang(new int[][] {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 0, 1 },
            });
            Assert.IsFalse(result);
        }
        
        [TestMethod]
        public void IsBoomerang_6()
        {
            var solution = new _1037_ValidBoomerang();
            var result = solution.IsBoomerang(new int[][] {
                new int[] { 1, 0 },
                new int[] { 0, 0 },
                new int[] { 2, 0 },
            });
            Assert.IsFalse(result);
        }
    }
}
