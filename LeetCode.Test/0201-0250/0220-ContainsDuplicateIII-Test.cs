using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0220_ContainsDuplicateIII_Test
    {
        [TestMethod]
        public void ContainsNearbyAlmostDuplicate_1()
        {
            var solution = new _0220_ContainsDuplicateIII();
            var result = solution.ContainsNearbyAlmostDuplicate(new int[] { 1, 2, 3, 1 }, 3, 0);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsNearbyAlmostDuplicate_2()
        {
            var solution = new _0220_ContainsDuplicateIII();
            var result = solution.ContainsNearbyAlmostDuplicate(new int[] { 1, 0, 1, 1 }, 1, 2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsNearbyAlmostDuplicate_3()
        {
            var solution = new _0220_ContainsDuplicateIII();
            var result = solution.ContainsNearbyAlmostDuplicate(new int[] { 1, 5, 9, 1, 5, 9 }, 2, 3);
            Assert.IsFalse(result);
        }
    }
}
