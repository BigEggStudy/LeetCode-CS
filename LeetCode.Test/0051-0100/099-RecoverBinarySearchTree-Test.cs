using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _099_RecoverBinarySearchTree_Test
    {
        [TestMethod]
        public void RecoverTreeTest()
        {
            var solution = new _099_RecoverBinarySearchTree();
            var root = TestHelper.GenerateTree(new int?[] { 1, 3, null, null, 2 });
            solution.RecoverTree(root);
            AssertHelper.AssertTree(new int?[] { 3, 1, null, null, 2 }, root);
        }

        [TestMethod]
        public void RecoverTreeTest_2()
        {
            var solution = new _099_RecoverBinarySearchTree();
            var root = TestHelper.GenerateTree(new int?[] { 3, 1, 4, null, null, 2 });
            solution.RecoverTree(root);
            AssertHelper.AssertTree(new int?[] { 2, 1, 4, null, null, 3 }, root);
        }

        [TestMethod]
        public void RecoverTreeTest_3()
        {
            var solution = new _099_RecoverBinarySearchTree();
            var root = TestHelper.GenerateTree(new int?[] { 5, 1, 6, null, null, 3, 8 });
            solution.RecoverTree(root);
            AssertHelper.AssertTree(new int?[] { 3, 1, 6, null, null, 5, 8 }, root);
        }

        [TestMethod]
        public void RecoverTreeTest_4()
        {
            var solution = new _099_RecoverBinarySearchTree();
            var root = TestHelper.GenerateTree(new int?[] { 2, 3, 4, null, null, 1 });
            solution.RecoverTree(root);
            AssertHelper.AssertTree(new int?[] { 2, 1, 4, null, null, 3 }, root);
        }
    }
}
