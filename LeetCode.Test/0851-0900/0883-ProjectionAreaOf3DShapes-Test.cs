using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0883_ProjectionAreaOf3DShapes_Test
    {
        [TestMethod]
        public void ProjectionArea_1()
        {
            var solution = new _0883_ProjectionAreaOf3DShapes();
            var result = solution.ProjectionArea(new int[][] {
                new int[] { 2 },
            });
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ProjectionArea_2()
        {
            var solution = new _0883_ProjectionAreaOf3DShapes();
            var result = solution.ProjectionArea(new int[][] {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
            });
            Assert.AreEqual(17, result);
        }

        [TestMethod]
        public void ProjectionArea_3()
        {
            var solution = new _0883_ProjectionAreaOf3DShapes();
            var result = solution.ProjectionArea(new int[][] {
                new int[] { 1, 0 },
                new int[] { 0, 2 },
            });
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void ProjectionArea_4()
        {
            var solution = new _0883_ProjectionAreaOf3DShapes();
            var result = solution.ProjectionArea(new int[][] {
                new int[] { 1, 1, 1 },
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 1 },
            });
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void ProjectionArea_5()
        {
            var solution = new _0883_ProjectionAreaOf3DShapes();
            var result = solution.ProjectionArea(new int[][] {
                new int[] { 2, 2, 2 },
                new int[] { 2, 1, 2 },
                new int[] { 2, 2, 2 },
            });
            Assert.AreEqual(21, result);
        }
    }
}
