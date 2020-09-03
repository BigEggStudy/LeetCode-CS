using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _060_PermutationSequence_Test
    {
        [TestMethod]
        public void GetPermutationTest_1()
        {
            var solution = new _060_PermutationSequence();

            var result = solution.GetPermutation(1, 1);
            Assert.AreEqual("1", result);

            result = solution.GetPermutation(1, 0);
            Assert.AreEqual("1", result);

            result = solution.GetPermutation(1, -1);
            Assert.AreEqual("1", result);

            result = solution.GetPermutation(1, 2);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void GetPermutationTest_2()
        {
            var solution = new _060_PermutationSequence();

            var result = solution.GetPermutation(2, 1);
            Assert.AreEqual("12", result);

            result = solution.GetPermutation(2, 2);
            Assert.AreEqual("21", result);

            result = solution.GetPermutation(2, 0);
            Assert.AreEqual("12", result);

            result = solution.GetPermutation(2, -1);
            Assert.AreEqual("12", result);

            result = solution.GetPermutation(2, 3);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void GetPermutationTest_4()
        {
            var solution = new _060_PermutationSequence();

            var result = solution.GetPermutation(4, 1);
            Assert.AreEqual("1234", result);

            result = solution.GetPermutation(4, 2);
            Assert.AreEqual("1243", result);

            result = solution.GetPermutation(4, 3);
            Assert.AreEqual("1324", result);

            result = solution.GetPermutation(4, 4);
            Assert.AreEqual("1342", result);

            result = solution.GetPermutation(4, 5);
            Assert.AreEqual("1423", result);

            result = solution.GetPermutation(4, 6);
            Assert.AreEqual("1432", result);

            result = solution.GetPermutation(4, 7);
            Assert.AreEqual("2134", result);
        }
    }
}
