using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _050_Pow_Test
    {
        [TestMethod]
        public void MyPowTest_XEqualZero_NEqualZero()
        {
            var solution = new _050_Pow();
            var result = solution.MyPow(0, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MyPowTest_XEqualZero_NLargerThanZero()
        {
            var solution = new _050_Pow();
            var result = solution.MyPow(0, 1);
            Assert.AreEqual(0, result);

            result = solution.MyPow(0, 5);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MyPowTest_XEqualZero_NLessThanZero()
        {
            var solution = new _050_Pow();
            var result = solution.MyPow(0, -1);
            Assert.AreEqual(0, result);

            result = solution.MyPow(0, -5);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MyPowTest_XLargerThanZero_NEqualZero()
        {
            var solution = new _050_Pow();
            var result = solution.MyPow(5, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MyPowTest_XLargerThanZero_NLargerThanZero()
        {
            var solution = new _050_Pow();
            var result = solution.MyPow(5, 1);
            Assert.AreEqual(5, result);

            result = solution.MyPow(2, 5);
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void MyPowTest_XLargerThanZero_NLessThanZero()
        {
            var solution = new _050_Pow();
            var result = solution.MyPow(5, -1);
            Assert.AreEqual(0.2, result);

            result = solution.MyPow(2, -5);
            Assert.AreEqual(0.03125, result);
        }
        [TestMethod]
        public void MyPowTest_XLessThanZero_NEqualZero()
        {
            var solution = new _050_Pow();
            var result = solution.MyPow(-5, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MyPowTest_XLessThanZero_NLargerThanZero()
        {
            var solution = new _050_Pow();
            var result = solution.MyPow(-5, 1);
            Assert.AreEqual(-5, result);

            result = solution.MyPow(-2, 5);
            Assert.AreEqual(-32, result);

            result = solution.MyPow(-2, 6);
            Assert.AreEqual(64, result);
        }

        [TestMethod]
        public void MyPowTest_XLessThanZero_NLessThanZero()
        {
            var solution = new _050_Pow();
            var result = solution.MyPow(-5, -1);
            Assert.AreEqual(-0.2, result);

            result = solution.MyPow(-2, -5);
            Assert.AreEqual(-0.03125, result);

            result = solution.MyPow(-2, -6);
            Assert.AreEqual(0.015625, result);
        }

        [TestMethod]
        public void MyPowTest_LargeN()
        {
            var solution = new _050_Pow();
            var result = solution.MyPow(2.0, -2147483648);
            Assert.AreEqual(0, result);
        }
    }
}
