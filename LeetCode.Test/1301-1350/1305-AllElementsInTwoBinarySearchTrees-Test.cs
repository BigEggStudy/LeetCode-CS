using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1305_AllElementsInTwoBinarySearchTrees_Test
    {
        [TestMethod]
        public void GetAllElements_1()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 2, 1, 4 });
            var root2 = TestHelper.GenerateTree(new int?[] { 1, 0, 3 });

            var solution = new _1305_AllElementsInTwoBinarySearchTrees();
            var result = solution.GetAllElements(root1, root2);
            AssertHelper.AssertList(new int[] { 0, 1, 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void GetAllElements_2()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 0, -10, 10 });
            var root2 = TestHelper.GenerateTree(new int?[] { 5, 1, 7, 0, 2 });

            var solution = new _1305_AllElementsInTwoBinarySearchTrees();
            var result = solution.GetAllElements(root1, root2);
            AssertHelper.AssertList(new int[] { -10, 0, 0, 1, 2, 5, 7, 10 }, result);
        }

        [TestMethod]
        public void GetAllElements_3()
        {
            var root2 = TestHelper.GenerateTree(new int?[] { 5, 1, 7, 0, 2 });

            var solution = new _1305_AllElementsInTwoBinarySearchTrees();
            var result = solution.GetAllElements(null, root2);
            AssertHelper.AssertList(new int[] { 0, 1, 2, 5, 7 }, result);
        }

        [TestMethod]
        public void GetAllElements_4()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 0, -10, 10 });

            var solution = new _1305_AllElementsInTwoBinarySearchTrees();
            var result = solution.GetAllElements(root1, null);
            AssertHelper.AssertList(new int[] { -10, 0, 10 }, result);
        }

        [TestMethod]
        public void GetAllElements_5()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 1, null, 8 });
            var root2 = TestHelper.GenerateTree(new int?[] { 8, 1 });

            var solution = new _1305_AllElementsInTwoBinarySearchTrees();
            var result = solution.GetAllElements(root1, root2);
            AssertHelper.AssertList(new int[] { 1, 1, 8, 8 }, result);
        }

        [TestMethod]
        public void GetAllElements_6()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 99, 90, null, 8, null, 7, 85, null, null, null, 87 });
            var root2 = TestHelper.GenerateTree(new int?[] { 50, 2, 73, null, 34, 58, 80, 21, null, null, 64, 74, 92, 10, null, null, 68, null, null, 89, 100, null, null, 66, null, 84 });

            var solution = new _1305_AllElementsInTwoBinarySearchTrees();
            var result = solution.GetAllElements(root1, root2);
            AssertHelper.AssertList(new int[] { 2, 7, 8, 10, 21, 34, 50, 58, 64, 66, 68, 73, 74, 80, 84, 85, 87, 89, 90, 92, 99, 100 }, result);
        }
    }
}
