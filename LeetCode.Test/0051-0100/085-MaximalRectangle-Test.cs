using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _085_MaximalRectangle_Test
    {
        [TestMethod]
        public void MaximalRectangleTest()
        {
            var input = new char[3][]
            {
                new char[] { '1', '1', '1' },
                new char[] { '1', '0', '1' },
                new char[] { '1', '1', '1' }
            };

            var solution = new _085_MaximalRectangle();
            var result = solution.MaximalRectangle(input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MaximalRectangleTest_2()
        {
            var input = new char[5][]
            {
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '0', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' }
            };

            var solution = new _085_MaximalRectangle();
            var result = solution.MaximalRectangle(input);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void MaximalRectangleTest_3()
        {
            var input = new char[2][]
            {
                new char[] { '1', '0' },
                new char[] { '1', '0' }
            };

            var solution = new _085_MaximalRectangle();
            var result = solution.MaximalRectangle(input);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MaximalRectangleTest_OneItem()
        {
            var input = new char[1][]
            {
                new char[] { '1' }
            };

            var solution = new _085_MaximalRectangle();
            var result = solution.MaximalRectangle(input);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MaximalRectangleTest_OneItem_Zero()
        {
            var input = new char[1][]
            {
                new char[] { '0' }
            };

            var solution = new _085_MaximalRectangle();
            var result = solution.MaximalRectangle(input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaximalRectangleTest_OneRow()
        {
            var input = new char[1][]
            {
                new char[] { '1', '1', '1' }
            };

            var solution = new _085_MaximalRectangle();
            var result = solution.MaximalRectangle(input);

            Assert.AreEqual(3, result);
        }
    }
}
