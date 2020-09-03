using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1238_CircularPermutationInBinaryRepresentation_Test
    {
        [TestMethod]
        public void CircularPermutation_1()
        {
            var solution = new _1238_CircularPermutationInBinaryRepresentation();
            var result = solution.CircularPermutation(2, 3);
            AssertHelper.AssertList(new int[] { 3, 2, 0, 1 }, result);
        }

        [TestMethod]
        public void CircularPermutation_2()
        {
            var solution = new _1238_CircularPermutationInBinaryRepresentation();
            var result = solution.CircularPermutation(3, 2);
            AssertHelper.AssertList(new int[] { 2, 3, 1, 0, 4, 5, 7, 6 }, result);
        }
    }
}
