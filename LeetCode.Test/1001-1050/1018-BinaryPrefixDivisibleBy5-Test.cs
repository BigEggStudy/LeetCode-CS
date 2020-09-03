using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1018_BinaryPrefixDivisibleBy5_Test
    {
        [TestMethod]
        public void PrefixesDivBy5_1()
        {
            var solution = new _1018_BinaryPrefixDivisibleBy5();
            var result = solution.PrefixesDivBy5(new int[] { 0, 1, 1 });
            AssertHelper.AssertList(new bool[] { true, false, false }, result);
        }

        [TestMethod]
        public void PrefixesDivBy5_2()
        {
            var solution = new _1018_BinaryPrefixDivisibleBy5();
            var result = solution.PrefixesDivBy5(new int[] { 1, 1, 1 });
            AssertHelper.AssertList(new bool[] { false, false, false }, result);
        }

        [TestMethod]
        public void PrefixesDivBy5_3()
        {
            var solution = new _1018_BinaryPrefixDivisibleBy5();
            var result = solution.PrefixesDivBy5(new int[] { 0, 1, 1, 1, 1, 1 });
            AssertHelper.AssertList(new bool[] { true, false, false, false, true, false }, result);
        }

        [TestMethod]
        public void PrefixesDivBy5_4()
        {
            var solution = new _1018_BinaryPrefixDivisibleBy5();
            var result = solution.PrefixesDivBy5(new int[] { 1, 1, 1, 0, 1 });
            AssertHelper.AssertList(new bool[] { false, false, false, false, false }, result);
        }

        [TestMethod]
        public void PrefixesDivBy5_5()
        {
            var solution = new _1018_BinaryPrefixDivisibleBy5();
            var result = solution.PrefixesDivBy5(new int[] { 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1 });
            AssertHelper.AssertList(new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, true, true, true, true, false }, result);
        }
    }
}
