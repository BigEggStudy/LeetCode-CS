using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0515_FindLargestValueInEachTreeRow_Test
    {
        [TestMethod]
        public void LargestValues_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 3, 2, 5, 3, null, 9 });

            var solution = new _0515_FindLargestValueInEachTreeRow();
            var result = solution.LargestValues(root);
            AssertHelper.AssertList(new int[] { 1, 3, 9 }, result);
        }
    }
}
