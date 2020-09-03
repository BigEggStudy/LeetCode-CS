using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0538_ConvertBSTToGreaterTree_Test
    {
        [TestMethod]
        public void ConvertBST_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 5, 2, 13 });

            var solution = new _0538_ConvertBSTToGreaterTree();
            var result = solution.ConvertBST(root);
            AssertHelper.AssertTree(new int?[] { 18, 20, 13 }, result);
        }
    }
}
