using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0844_BackspaceStringCompare_Test
    {
        [TestMethod]
        public void BackspaceCompareTest_1()
        {
            var solution = new _0844_BackspaceStringCompare();
            Assert.IsTrue(solution.BackspaceCompare("ab#c", "ad#c"));
        }

        [TestMethod]
        public void BackspaceCompareTest_2()
        {
            var solution = new _0844_BackspaceStringCompare();
            Assert.IsTrue(solution.BackspaceCompare("ab##", "c#d#"));
        }

        [TestMethod]
        public void BackspaceCompareTest_3()
        {
            var solution = new _0844_BackspaceStringCompare();
            Assert.IsTrue(solution.BackspaceCompare("a##c", "#a#c"));
        }

        [TestMethod]
        public void BackspaceCompareTest_4()
        {
            var solution = new _0844_BackspaceStringCompare();
            Assert.IsFalse(solution.BackspaceCompare("a#c", "b"));
        }

        [TestMethod]
        public void BackspaceCompareTest_5()
        {
            var solution = new _0844_BackspaceStringCompare();
            Assert.IsTrue(solution.BackspaceCompare("da#c#", "a#c#d"));
        }
    }
}
