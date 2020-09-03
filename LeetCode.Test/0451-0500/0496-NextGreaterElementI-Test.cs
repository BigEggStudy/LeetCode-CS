using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0496_NextGreaterElementI_Test
    {
        [TestMethod]
        public void NextGreaterElement_1()
        {
            var solution = new _0496_NextGreaterElementI();
            var result = solution.NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });
            AssertHelper.AssertArray(new int[] { -1, 3, -1 }, result);
        }

        [TestMethod]
        public void NextGreaterElement_2()
        {
            var solution = new _0496_NextGreaterElementI();
            var result = solution.NextGreaterElement(new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 });
            AssertHelper.AssertArray(new int[] { 3, -1 }, result);
        }

        [TestMethod]
        public void NextGreaterElement_3()
        {
            var solution = new _0496_NextGreaterElementI();
            var result = solution.NextGreaterElement(new int[] { }, new int[] { 1, 2, 3, 4 });
            AssertHelper.AssertArray(new int[] { }, result);
        }

        [TestMethod]
        public void NextGreaterElement_4()
        {
            var solution = new _0496_NextGreaterElementI();
            var result = solution.NextGreaterElement(new int[] { 137, 59, 92, 122, 52, 131, 79, 236 }, new int[] { 137, 59, 92, 122, 52, 131, 79, 236 });
            AssertHelper.AssertArray(new int[] { 236, 92, 122, 131, 131, 236, 236, -1 }, result);
        }
    }
}
