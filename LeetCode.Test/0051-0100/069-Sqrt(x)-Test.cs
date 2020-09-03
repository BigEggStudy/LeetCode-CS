using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _069_Sqrt_Test
    {
        [TestMethod]
        public void MySqrt_LessThanZero()
        {
            var solution = new _069_Sqrt();
            var result = solution.MySqrt(-1);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void MySqrt_Zero()
        {
            var solution = new _069_Sqrt();
            var result = solution.MySqrt(0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MySqrt_One()
        {
            var solution = new _069_Sqrt();
            var result = solution.MySqrt(1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MySqrt_Two()
        {
            var solution = new _069_Sqrt();
            var result = solution.MySqrt(2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MySqrt_Three()
        {
            var solution = new _069_Sqrt();
            var result = solution.MySqrt(3);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MySqrt_Four()
        {
            var solution = new _069_Sqrt();
            var result = solution.MySqrt(4);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MySqrt_Five()
        {
            var solution = new _069_Sqrt();
            var result = solution.MySqrt(5);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MySqrt_Max()
        {
            var solution = new _069_Sqrt();
            var result = solution.MySqrt(int.MaxValue);

            Assert.AreEqual(46340, result);
        }
    }
}
