using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1026_MaximumDifferenceBetweenNodeAndAncestor_Test
    {
        [TestMethod]
        public void MaxAncestorDiff_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 8, 3, 10, 1, 6, null, 14, null, null, 4, 7, 13 });

            var solution = new _1026_MaximumDifferenceBetweenNodeAndAncestor();
            var result = solution.MaxAncestorDiff(root);
            Assert.AreEqual(7, result);
        }
    }
}
