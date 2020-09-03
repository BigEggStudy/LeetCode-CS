using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1056_ConfusingNumber_Test
    {
        [TestMethod]
        public void ConfusingNumber_1()
        {
            var solution = new _1056_ConfusingNumber();
            var result = solution.ConfusingNumber(6);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ConfusingNumber_2()
        {
            var solution = new _1056_ConfusingNumber();
            var result = solution.ConfusingNumber(89);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ConfusingNumber_3()
        {
            var solution = new _1056_ConfusingNumber();
            var result = solution.ConfusingNumber(11);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ConfusingNumber_4()
        {
            var solution = new _1056_ConfusingNumber();
            var result = solution.ConfusingNumber(25);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ConfusingNumber_5()
        {
            var solution = new _1056_ConfusingNumber();
            var result = solution.ConfusingNumber(8000);
            Assert.IsTrue(result);
        }
    }
}
