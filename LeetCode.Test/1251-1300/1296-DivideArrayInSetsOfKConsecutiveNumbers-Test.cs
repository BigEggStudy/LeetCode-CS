using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1296_DivideArrayInSetsOfKConsecutiveNumbers_Test
    {
        [TestMethod]
        public void IsPossibleDivide_1()
        {
            var solution = new _1296_DivideArrayInSetsOfKConsecutiveNumbers();
            var result = solution.IsPossibleDivide(new int[] { 1, 2, 3, 3, 4, 4, 5, 6 }, 4);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPossibleDivide_2()
        {
            var solution = new _1296_DivideArrayInSetsOfKConsecutiveNumbers();
            var result = solution.IsPossibleDivide(new int[] { 3, 2, 1, 2, 3, 4, 3, 4, 5, 9, 10, 11 }, 3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPossibleDivide_3()
        {
            var solution = new _1296_DivideArrayInSetsOfKConsecutiveNumbers();
            var result = solution.IsPossibleDivide(new int[] { 3, 3, 2, 2, 1, 1 }, 3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPossibleDivide_4()
        {
            var solution = new _1296_DivideArrayInSetsOfKConsecutiveNumbers();
            var result = solution.IsPossibleDivide(new int[] { 1, 2, 3, 4 }, 3);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPossibleDivide_5()
        {
            var solution = new _1296_DivideArrayInSetsOfKConsecutiveNumbers();
            var result = solution.IsPossibleDivide(new int[] { 1, 3, 3, 4, 5, 5 }, 3);
            Assert.IsFalse(result);
        }
    }
}
