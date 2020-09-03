using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0606_ConstructStringFromBinaryTree_Test
    {
        [TestMethod]
        public void Tree2str_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4 });

            var solution = new _0606_ConstructStringFromBinaryTree();
            var result = solution.Tree2str(root);
            Assert.AreEqual("1(2(4))(3)", result);
        }

        [TestMethod]
        public void Tree2str_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, null, 4 });

            var solution = new _0606_ConstructStringFromBinaryTree();
            var result = solution.Tree2str(root);
            Assert.AreEqual("1(2()(4))(3)", result);
        }
    }
}
