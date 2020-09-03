using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0263_UglyNumber_Test
    {
        [TestMethod]
        public void IsUgly_1()
        {
            var solution = new _0263_UglyNumber();
            var result = solution.IsUgly(6);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUgly_2()
        {
            var solution = new _0263_UglyNumber();
            var result = solution.IsUgly(8);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUgly_3()
        {
            var solution = new _0263_UglyNumber();
            var result = solution.IsUgly(1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUgly_4()
        {
            var solution = new _0263_UglyNumber();
            var result = solution.IsUgly(-1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsUgly_5()
        {
            var solution = new _0263_UglyNumber();
            var result = solution.IsUgly(14);
            Assert.IsFalse(result);
        }
    }
}
