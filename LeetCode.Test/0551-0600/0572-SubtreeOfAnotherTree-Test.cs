using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0572_SubtreeOfAnotherTree_Test
    {
        [TestMethod]
        public void IsSubtree_1()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 3, 4, 5, 1, 2 });
            var root2 = TestHelper.GenerateTree(new int?[] { 4, 1, 2 });

            var solution = new _0572_SubtreeOfAnotherTree();
            var result = solution.IsSubtree(root1, root2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSubtree_2()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 3, 4, 5, 1, 2, null, null, 0 });
            var root2 = TestHelper.GenerateTree(new int?[] { 4, 1, 2 });

            var solution = new _0572_SubtreeOfAnotherTree();
            var result = solution.IsSubtree(root1, root2);
            Assert.IsFalse(result);
        }
    }
}
