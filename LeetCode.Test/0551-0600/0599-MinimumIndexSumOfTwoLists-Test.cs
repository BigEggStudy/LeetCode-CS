using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0599_MinimumIndexSumOfTwoLists_Test
    {
        [TestMethod]
        public void FindRestaurant_1()
        {
            var solution = new _0599_MinimumIndexSumOfTwoLists();
            var result = solution.FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" });
            AssertHelper.AssertArray(new string[] { "Shogun" }, result);
        }

        [TestMethod]
        public void FindRestaurant_2()
        {
            var solution = new _0599_MinimumIndexSumOfTwoLists();
            var result = solution.FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "KFC", "Shogun", "Burger King" });
            AssertHelper.AssertArray(new string[] { "Shogun" }, result);
        }
    }
}
