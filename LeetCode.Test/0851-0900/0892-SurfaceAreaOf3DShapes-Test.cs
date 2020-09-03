using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0892_SurfaceAreaOf3DShapes_Test
    {
        [TestMethod]
        public void SurfaceArea_1()
        {
            var solution = new _0892_SurfaceAreaOf3DShapes();
            var result = solution.SurfaceArea(new int[][] {
                new int[] { 2 },
            });
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void SurfaceArea_2()
        {
            var solution = new _0892_SurfaceAreaOf3DShapes();
            var result = solution.SurfaceArea(new int[][] {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
            });
            Assert.AreEqual(34, result);
        }

        [TestMethod]
        public void SurfaceArea_3()
        {
            var solution = new _0892_SurfaceAreaOf3DShapes();
            var result = solution.SurfaceArea(new int[][] {
                new int[] { 1, 0 },
                new int[] { 0, 2 },
            });
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void SurfaceArea_4()
        {
            var solution = new _0892_SurfaceAreaOf3DShapes();
            var result = solution.SurfaceArea(new int[][] {
                new int[] { 1, 1, 1 },
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 1 },
            });
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void SurfaceArea_5()
        {
            var solution = new _0892_SurfaceAreaOf3DShapes();
            var result = solution.SurfaceArea(new int[][] {
                new int[] { 2, 2, 2 },
                new int[] { 2, 1, 2 },
                new int[] { 2, 2, 2 },
            });
            Assert.AreEqual(46, result);
        }
    }
}
