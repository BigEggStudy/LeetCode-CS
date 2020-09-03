using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0763_PartitionLabels_Test
    {
        [TestMethod]
        public void PartitionLabels_1()
        {
            var solution = new _0763_PartitionLabels();
            var result = solution.PartitionLabels("ababcbacadefegdehijhklij");
            AssertHelper.AssertList(new int[] { 9, 7, 8 }, result);
        }
    }
}
