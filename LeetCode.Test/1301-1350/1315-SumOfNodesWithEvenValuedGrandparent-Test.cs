using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1315_SumOfNodesWithEvenValuedGrandparent_Test
    {
        [TestMethod]
        public void SumEvenGrandparent_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 6, 7, 8, 2, 7, 1, 3, 9, null, 1, 4, null, null, null, 5 });

            var solution = new _1315_SumOfNodesWithEvenValuedGrandparent();
            var result = solution.SumEvenGrandparent(root);
            Assert.AreEqual(18, result);
        }
    }
}
