using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeetCode.Test
{
    [TestClass]
    public class _1304_FindNUniqueIntegersSumUpToZero_Test
    {
        [TestMethod]
        public void SumZero_1()
        {
            var solution = new _1304_FindNUniqueIntegersSumUpToZero();
            var result = solution.SumZero(5);
            Assert.AreEqual(0, result.Sum());
        }

        [TestMethod]
        public void SumZero_2()
        {
            var solution = new _1304_FindNUniqueIntegersSumUpToZero();
            var result = solution.SumZero(3);
            Assert.AreEqual(0, result.Sum());
        }

        [TestMethod]
        public void SumZero_3()
        {
            var solution = new _1304_FindNUniqueIntegersSumUpToZero();
            var result = solution.SumZero(1);
            Assert.AreEqual(0, result.Sum());
        }
    }
}
