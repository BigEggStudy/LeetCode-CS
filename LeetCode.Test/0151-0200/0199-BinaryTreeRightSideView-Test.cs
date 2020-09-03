using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0199_BinaryTreeRightSideView_Test
    {
        [TestMethod]
        public void RightSideViewTest()
        {
            var solution = new _0199_BinaryTreeRightSideView();
            var result = solution.RightSideView(TestHelper.GenerateTree(new int?[] { 1, 2, 3, null, 5, null, 4 }));
            AssertHelper.AssertList(new int[] { 1, 3, 4 }, result);
        }
    }
}
