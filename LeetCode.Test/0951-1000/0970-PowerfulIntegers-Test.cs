using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeetCode.Test
{
    [TestClass]
    public class _0970_PowerfulIntegers_Test
    {
        [TestMethod]
        public void PowerfulIntegers_1()
        {
            var solution = new _0970_PowerfulIntegers();
            var result = solution.PowerfulIntegers(2, 3, 10);
            AssertHelper.AssertList(new int[] { 2, 3, 4, 5, 7, 9, 10 }, result.OrderBy(n => n).ToList());
        }

        [TestMethod]
        public void PowerfulIntegers_2()
        {
            var solution = new _0970_PowerfulIntegers();
            var result = solution.PowerfulIntegers(3, 5, 15);
            AssertHelper.AssertList(new int[] { 2, 4, 6, 8, 10, 14 }, result.OrderBy(n => n).ToList());
        }
    }
}
