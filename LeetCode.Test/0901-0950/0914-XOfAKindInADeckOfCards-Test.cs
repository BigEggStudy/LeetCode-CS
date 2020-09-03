using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0914_XOfAKindInADeckOfCards_Test
    {
        [TestMethod]
        public void HasGroupsSizeX_1()
        {
            var solution = new _0914_XOfAKindInADeckOfCards();
            var result = solution.HasGroupsSizeX(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasGroupsSizeX_2()
        {
            var solution = new _0914_XOfAKindInADeckOfCards();
            var result = solution.HasGroupsSizeX(new int[] { 1, 1, 1, 2, 2, 2, 3, 3 });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasGroupsSizeX_3()
        {
            var solution = new _0914_XOfAKindInADeckOfCards();
            var result = solution.HasGroupsSizeX(new int[] { 1 });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasGroupsSizeX_4()
        {
            var solution = new _0914_XOfAKindInADeckOfCards();
            var result = solution.HasGroupsSizeX(new int[] { 1, 1 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasGroupsSizeX_5()
        {
            var solution = new _0914_XOfAKindInADeckOfCards();
            var result = solution.HasGroupsSizeX(new int[] { 1, 1, 2, 2, 2, 2 });
            Assert.IsTrue(result);
        }
    }
}
