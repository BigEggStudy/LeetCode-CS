using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1442_CountTripletsThatCanFormTwoArraysOfEqualXOR_Test
    {
        [TestMethod]
        public void CountTriplets_1()
        {
            var solution = new _1442_CountTripletsThatCanFormTwoArraysOfEqualXOR();
            var result = solution.CountTriplets(new int[] { 2, 3, 1, 6, 7 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void CountTriplets_2()
        {
            var solution = new _1442_CountTripletsThatCanFormTwoArraysOfEqualXOR();
            var result = solution.CountTriplets(new int[] { 1, 1, 1, 1, 1 });
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void CountTriplets_3()
        {
            var solution = new _1442_CountTripletsThatCanFormTwoArraysOfEqualXOR();
            var result = solution.CountTriplets(new int[] { 2, 3 });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CountTriplets_4()
        {
            var solution = new _1442_CountTripletsThatCanFormTwoArraysOfEqualXOR();
            var result = solution.CountTriplets(new int[] { 1, 3, 5, 7, 9 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CountTriplets_5()
        {
            var solution = new _1442_CountTripletsThatCanFormTwoArraysOfEqualXOR();
            var result = solution.CountTriplets(new int[] { 7, 11, 12, 9, 5, 2, 7, 17, 22 });
            Assert.AreEqual(8, result);
        }
    }
}
