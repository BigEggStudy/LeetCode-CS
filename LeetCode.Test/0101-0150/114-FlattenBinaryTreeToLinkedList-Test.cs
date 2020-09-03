using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _114_FlattenBinaryTreeToLinkedList_Test
    {
        [TestMethod]
        public void FlattenTest()
        {
            var solution = new _114_FlattenBinaryTreeToLinkedList();
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 5, 3, 4, null, 6 });
            solution.Flatten(root);
            AssertHelper.AssertTree(new int?[] { 1, null, 2, null, 3, null, 4, null, 5, null, 6 }, root);
        }

        [TestMethod]
        public void FlattenTest_2()
        {
            var solution = new _114_FlattenBinaryTreeToLinkedList();
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, null, 3 });
            solution.Flatten(root);
            AssertHelper.AssertTree(new int?[] { 1, null, 2, null, 3 }, root);
        }

        [TestMethod]
        public void FlattenTest_NoLeft()
        {
            var solution = new _114_FlattenBinaryTreeToLinkedList();
            var root = TestHelper.GenerateTree(new int?[] { 1, null, 2, 3, 6, 4, 5 });
            solution.Flatten(root);
            AssertHelper.AssertTree(new int?[] { 1, null, 2, null, 3, null, 4, null, 5, null, 6 }, root);
        }

        [TestMethod]
        public void FlattenTest_NoRight()
        {
            var solution = new _114_FlattenBinaryTreeToLinkedList();
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, null, 3, 4 });
            solution.Flatten(root);
            AssertHelper.AssertTree(new int?[] { 1, null, 2, null, 3, null, 4 }, root);
        }

        [TestMethod]
        public void FlattenTest_Null()
        {
            var solution = new _114_FlattenBinaryTreeToLinkedList();
            solution.Flatten(null);
        }
    }
}
