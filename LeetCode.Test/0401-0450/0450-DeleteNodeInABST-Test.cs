using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0450_DeleteNodeInABST_Test
    {
        [TestMethod]
        public void DeleteNode_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 5, 3, 6, 2, 4, null, 7 });

            var solution = new _0450_DeleteNodeInABST();
            var result = solution.DeleteNode(root, 3);
            AssertHelper.AssertTree(new int?[] { 5, 4, 6, 2, null, null, 7 }, result);
        }
    }
}
