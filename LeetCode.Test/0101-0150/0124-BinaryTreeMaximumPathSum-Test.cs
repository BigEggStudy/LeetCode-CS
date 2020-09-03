using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0124_BinaryTreeMaximumPathSum_Test
    {
        [TestMethod]
        public void MaxPathSumTest_1()
        {
            var input = TestHelper.GenerateTree(new int?[] { 1, 2, 3 });

            var solution = new _0124_BinaryTreeMaximumPathSum();
            var result = solution.MaxPathSum(input);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void MaxPathSumTest_2()
        {
            var input = TestHelper.GenerateTree(new int?[] { 1, 2 });

            var solution = new _0124_BinaryTreeMaximumPathSum();
            var result = solution.MaxPathSum(input);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MaxPathSumTest_3()
        {
            var input = TestHelper.GenerateTree(new int?[] { 1, null, 3 });

            var solution = new _0124_BinaryTreeMaximumPathSum();
            var result = solution.MaxPathSum(input);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaxPathSumTest_4()
        {
            var input = TestHelper.GenerateTree(new int?[] { 1, -5, 2 });

            var solution = new _0124_BinaryTreeMaximumPathSum();
            var result = solution.MaxPathSum(input);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MaxPathSumTest_5()
        {
            var input = TestHelper.GenerateTree(new int?[] { -1, -5, 2 });

            var solution = new _0124_BinaryTreeMaximumPathSum();
            var result = solution.MaxPathSum(input);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MaxPathSumTest_6()
        {
            var input = TestHelper.GenerateTree(new int?[] { -10, 9, 20, null, null, 15, 7 });

            var solution = new _0124_BinaryTreeMaximumPathSum();
            var result = solution.MaxPathSum(input);
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void MaxPathSumTest_7()
        {
            var input = TestHelper.GenerateTree(new int?[] { -3, -1 });

            var solution = new _0124_BinaryTreeMaximumPathSum();
            var result = solution.MaxPathSum(input);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void MaxPathSumTest_8()
        {
            var input = TestHelper.GenerateTree(new int?[] { -3, -6 });

            var solution = new _0124_BinaryTreeMaximumPathSum();
            var result = solution.MaxPathSum(input);
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void MaxPathSumTest_9()
        {
            var input = TestHelper.GenerateTree(new int?[] { 0, 1, 1 });

            var solution = new _0124_BinaryTreeMaximumPathSum();
            var result = solution.MaxPathSum(input);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MaxPathSumTest_10()
        {
            var input = TestHelper.GenerateTree(new int?[] { 1, -2, -3, 1, 3, -2, null, -1 });

            var solution = new _0124_BinaryTreeMaximumPathSum();
            var result = solution.MaxPathSum(input);
            Assert.AreEqual(3, result);
        }
    }
}
