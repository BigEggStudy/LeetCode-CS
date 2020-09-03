using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0889_ConstructBinaryTreeFromPreorderAndPostorderTraversal_Test
    {
        [TestMethod]
        public void ConstructFromPrePost_1()
        {
            var solution = new _0889_ConstructBinaryTreeFromPreorderAndPostorderTraversal();
            var result = solution.ConstructFromPrePost(new int[] { 1, 2, 4, 5, 3, 6, 7 }, new int[] { 4, 5, 2, 6, 7, 3, 1 });
            AssertHelper.AssertTree(new int?[] { 1, 2, 3, 4, 5, 6, 7 }, result);
        }
    }
}
