using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _106_ConstructBinaryTreeFromInorderAndPostorderTraversal_Test
    {
        [TestMethod]
        public void BuildTreeTest()
        {
            var solution = new _106_ConstructBinaryTreeFromInorderAndPostorderTraversal();
            var result = solution.BuildTree(new int[] { 9, 3, 15, 20, 7 }, new int[] { 9, 15, 7, 20, 3 });
            AssertHelper.AssertTree(new int?[] { 3, 9, 20, null, null, 15, 7 }, result);
        }

        [TestMethod]
        public void BuildTreeTest_Empty()
        {
            var solution = new _106_ConstructBinaryTreeFromInorderAndPostorderTraversal();
            var result = solution.BuildTree(new int[] { }, new int[] { });
            Assert.IsNull(result);
        }
    }
}
