using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1431_KidsWithTheGreatestNumberOfCandies_Test
    {
        [TestMethod]
        public void KidsWithCandies_1()
        {
            var solution = new _1431_KidsWithTheGreatestNumberOfCandies();
            var result = solution.KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3);
            AssertHelper.AssertList(new bool[] { true, true, true, false, true }, result);
        }

        [TestMethod]
        public void KidsWithCandies_2()
        {
            var solution = new _1431_KidsWithTheGreatestNumberOfCandies();
            var result = solution.KidsWithCandies(new int[] { 4, 2, 1, 1, 2 }, 1);
            AssertHelper.AssertList(new bool[] { true, false, false, false, false }, result);
        }

        [TestMethod]
        public void KidsWithCandies_3()
        {
            var solution = new _1431_KidsWithTheGreatestNumberOfCandies();
            var result = solution.KidsWithCandies(new int[] { 12, 1, 12 }, 10);
            AssertHelper.AssertList(new bool[] { true, false, true }, result);
        }
    }
}
