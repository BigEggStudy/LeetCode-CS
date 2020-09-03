using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0427_ConstructQuadTree_Test
    {
        [TestMethod]
        public void Construct_1()
        {
            var solution = new _0427_ConstructQuadTree();
            var result = solution.Construct(new int[][] {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
            });
            Assert.IsFalse(result.val);
            Assert.IsFalse(result.isLeaf);

            var topLeft = result.topLeft;
            Assert.IsFalse(topLeft.val);
            Assert.IsTrue(topLeft.isLeaf);
            Assert.IsNull(topLeft.topLeft);
            Assert.IsNull(topLeft.topRight);
            Assert.IsNull(topLeft.bottomLeft);
            Assert.IsNull(topLeft.bottomRight);

            var topRight = result.topRight;
            Assert.IsTrue(topRight.val);
            Assert.IsTrue(topRight.isLeaf);
            Assert.IsNull(topRight.topLeft);
            Assert.IsNull(topRight.topRight);
            Assert.IsNull(topRight.bottomLeft);
            Assert.IsNull(topRight.bottomRight);

            var bottomLeft = result.bottomLeft;
            Assert.IsTrue(bottomLeft.val);
            Assert.IsTrue(bottomLeft.isLeaf);
            Assert.IsNull(bottomLeft.topLeft);
            Assert.IsNull(bottomLeft.topRight);
            Assert.IsNull(bottomLeft.bottomLeft);
            Assert.IsNull(bottomLeft.bottomRight);

            var bottomRight = result.bottomRight;
            Assert.IsFalse(bottomRight.val);
            Assert.IsTrue(bottomRight.isLeaf);
            Assert.IsNull(bottomRight.topLeft);
            Assert.IsNull(bottomRight.topRight);
            Assert.IsNull(bottomRight.bottomLeft);
            Assert.IsNull(bottomRight.bottomRight);
        }

        [TestMethod]
        public void Construct_2()
        {
            var solution = new _0427_ConstructQuadTree();
            var result = solution.Construct(new int[][] {
                new int[] { 1, 1, 1, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
                new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
                new int[] { 1, 1, 1, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0, 0, 0, 0 },
            });
            Assert.IsFalse(result.val);
            Assert.IsFalse(result.isLeaf);

            var topLeft = result.topLeft;
            Assert.IsTrue(topLeft.val);
            Assert.IsTrue(topLeft.isLeaf);
            Assert.IsNull(topLeft.topLeft);
            Assert.IsNull(topLeft.topRight);
            Assert.IsNull(topLeft.bottomLeft);
            Assert.IsNull(topLeft.bottomRight);

            var topRight = result.topRight;
            Assert.IsFalse(topRight.val);
            Assert.IsFalse(topRight.isLeaf);

            var topLeft2 = topRight.topLeft;
            Assert.IsFalse(topLeft2.val);
            Assert.IsTrue(topLeft2.isLeaf);
            Assert.IsNull(topLeft2.topLeft);
            Assert.IsNull(topLeft2.topRight);
            Assert.IsNull(topLeft2.bottomLeft);
            Assert.IsNull(topLeft2.bottomRight);

            var topRight2 = topRight.topRight;
            Assert.IsFalse(topRight2.val);
            Assert.IsTrue(topRight2.isLeaf);
            Assert.IsNull(topRight2.topLeft);
            Assert.IsNull(topRight2.topRight);
            Assert.IsNull(topRight2.bottomLeft);
            Assert.IsNull(topRight2.bottomRight);

            var bottomLeft2 = topRight.bottomLeft;
            Assert.IsTrue(bottomLeft2.val);
            Assert.IsTrue(bottomLeft2.isLeaf);
            Assert.IsNull(bottomLeft2.topLeft);
            Assert.IsNull(bottomLeft2.topRight);
            Assert.IsNull(bottomLeft2.bottomLeft);
            Assert.IsNull(bottomLeft2.bottomRight);

            var bottomRight2 = topRight.bottomRight;
            Assert.IsTrue(bottomRight2.val);
            Assert.IsTrue(bottomRight2.isLeaf);
            Assert.IsNull(bottomRight2.topLeft);
            Assert.IsNull(bottomRight2.topRight);
            Assert.IsNull(bottomRight2.bottomLeft);
            Assert.IsNull(bottomRight2.bottomRight);


            var bottomLeft = result.bottomLeft;
            Assert.IsTrue(bottomLeft.val);
            Assert.IsTrue(bottomLeft.isLeaf);
            Assert.IsNull(bottomLeft.topLeft);
            Assert.IsNull(bottomLeft.topRight);
            Assert.IsNull(bottomLeft.bottomLeft);
            Assert.IsNull(bottomLeft.bottomRight);

            var bottomRight = result.bottomRight;
            Assert.IsFalse(bottomRight.val);
            Assert.IsTrue(bottomRight.isLeaf);
            Assert.IsNull(bottomRight.topLeft);
            Assert.IsNull(bottomRight.topRight);
            Assert.IsNull(bottomRight.bottomLeft);
            Assert.IsNull(bottomRight.bottomRight);
        }

        [TestMethod]
        public void Construct_3()
        {
            var solution = new _0427_ConstructQuadTree();
            var result = solution.Construct(new int[][] {
                new int[] { 1, 1 },
                new int[] { 1, 1 },
            });
            Assert.IsTrue(result.val);
            Assert.IsTrue(result.isLeaf);
            Assert.IsNull(result.topLeft);
            Assert.IsNull(result.topRight);
            Assert.IsNull(result.bottomLeft);
            Assert.IsNull(result.bottomRight);
        }

        [TestMethod]
        public void Construct_4()
        {
            var solution = new _0427_ConstructQuadTree();
            var result = solution.Construct(new int[][] {
                new int[] { 0 },
            });
            Assert.IsFalse(result.val);
            Assert.IsTrue(result.isLeaf);
            Assert.IsNull(result.topLeft);
            Assert.IsNull(result.topRight);
            Assert.IsNull(result.bottomLeft);
            Assert.IsNull(result.bottomRight);
        }

        [TestMethod]
        public void Construct_5()
        {
            var solution = new _0427_ConstructQuadTree();
            var result = solution.Construct(new int[][] {
                new int[] { 1, 1, 0, 0 },
                new int[] { 1, 1, 0, 0 },
                new int[] { 0, 0, 1, 1 },
                new int[] { 0, 0, 1, 1 },
            });
            Assert.IsFalse(result.val);
            Assert.IsFalse(result.isLeaf);

            var topLeft = result.topLeft;
            Assert.IsTrue(topLeft.val);
            Assert.IsTrue(topLeft.isLeaf);
            Assert.IsNull(topLeft.topLeft);
            Assert.IsNull(topLeft.topRight);
            Assert.IsNull(topLeft.bottomLeft);
            Assert.IsNull(topLeft.bottomRight);

            var topRight = result.topRight;
            Assert.IsFalse(topRight.val);
            Assert.IsTrue(topRight.isLeaf);
            Assert.IsNull(topRight.topLeft);
            Assert.IsNull(topRight.topRight);
            Assert.IsNull(topRight.bottomLeft);
            Assert.IsNull(topRight.bottomRight);

            var bottomLeft = result.bottomLeft;
            Assert.IsFalse(bottomLeft.val);
            Assert.IsTrue(bottomLeft.isLeaf);
            Assert.IsNull(bottomLeft.topLeft);
            Assert.IsNull(bottomLeft.topRight);
            Assert.IsNull(bottomLeft.bottomLeft);
            Assert.IsNull(bottomLeft.bottomRight);

            var bottomRight = result.bottomRight;
            Assert.IsTrue(bottomRight.val);
            Assert.IsTrue(bottomRight.isLeaf);
            Assert.IsNull(bottomRight.topLeft);
            Assert.IsNull(bottomRight.topRight);
            Assert.IsNull(bottomRight.bottomLeft);
            Assert.IsNull(bottomRight.bottomRight);
        }
    }
}
