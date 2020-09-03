using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0998_MaximumBinaryTreeII_Test
    {
        [TestMethod]
        public void InsertIntoMaxTree_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 4, 1, 3, null, null, 2 });

            var solution = new _0998_MaximumBinaryTreeII();
            var result = solution.InsertIntoMaxTree(root, 5);
            AssertHelper.AssertTree(new int?[] { 5, 4, null, 1, 3, null, null, 2 }, result);
        }

        [TestMethod]
        public void InsertIntoMaxTree_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 5, 2, 4, null, 1 });

            var solution = new _0998_MaximumBinaryTreeII();
            var result = solution.InsertIntoMaxTree(root, 3);
            AssertHelper.AssertTree(new int?[] { 5, 2, 4, null, 1, null, 3 }, result);
        }

        [TestMethod]
        public void InsertIntoMaxTree_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 5, 2, 3, null, 1 });

            var solution = new _0998_MaximumBinaryTreeII();
            var result = solution.InsertIntoMaxTree(root, 4);
            AssertHelper.AssertTree(new int?[] { 5, 2, 4, null, 1, 3 }, result);
        }
    }
}
