using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _054_SpiralMatrix_Test
    {
        [TestMethod]
        public void MyTestMethod_Square_Odd()
        {
            var input = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            var solution = new _054_SpiralMatrix();
            var result = solution.SpiralOrder(input);

            AssertHelper.AssertList(new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }, result);
        }

        [TestMethod]
        public void MyTestMethod_Square_Even()
        {
            var input = new int[,]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            var solution = new _054_SpiralMatrix();
            var result = solution.SpiralOrder(input);

            AssertHelper.AssertList(new int[] { 1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10 }, result);
        }

        [TestMethod]
        public void MyTestMethod_RowLargerThanColumn()
        {
            var input = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
                { 10, 11, 12 }
            };

            var solution = new _054_SpiralMatrix();
            var result = solution.SpiralOrder(input);

            AssertHelper.AssertList(new int[] { 1, 2, 3, 6, 9, 12, 11, 10, 7, 4, 5, 8 }, result);
        }

        [TestMethod]
        public void MyTestMethod_ColumnLargerThanRow()
        {
            var input = new int[,]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            var solution = new _054_SpiralMatrix();
            var result = solution.SpiralOrder(input);

            AssertHelper.AssertList(new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }, result);
        }

        [TestMethod]
        public void MyTestMethod_OneItem()
        {
            var input = new int[,]
            {
                { 1 }
            };

            var solution = new _054_SpiralMatrix();
            var result = solution.SpiralOrder(input);

            AssertHelper.AssertList(new int[] { 1 }, result);
        }

        [TestMethod]
        public void MyTestMethod_OneRow()
        {
            var input = new int[,]
            {
                { 1, 2, 3, 4, 5, 6 }
            };

            var solution = new _054_SpiralMatrix();
            var result = solution.SpiralOrder(input);

            AssertHelper.AssertList(new int[] { 1, 2, 3, 4, 5, 6 }, result);
        }

        [TestMethod]
        public void MyTestMethod_OneColumn()
        {
            var input = new int[,]
            {
                { 1 },
                { 2 },
                { 3 },
                { 4 },
                { 5 },
                { 6 }
            };

            var solution = new _054_SpiralMatrix();
            var result = solution.SpiralOrder(input);

            AssertHelper.AssertList(new int[] { 1, 2, 3, 4, 5, 6 }, result);
        }

        [TestMethod]
        public void MyTestMethod_TwoRows()
        {
            var input = new int[,]
            {
                { 1, 2, 3, 4, 5, 6 },
                { 11, 12, 13, 14, 15, 16 },
            };

            var solution = new _054_SpiralMatrix();
            var result = solution.SpiralOrder(input);

            AssertHelper.AssertList(new int[] { 1, 2, 3, 4, 5, 6, 16, 15, 14, 13, 12, 11 }, result);
        }

        [TestMethod]
        public void MyTestMethod_TwoColumns()
        {
            var input = new int[,]
            {
                { 1, 11 },
                { 2, 12 },
                { 3, 13 },
                { 4, 14 },
                { 5, 15 },
                { 6, 16 }
            };

            var solution = new _054_SpiralMatrix();
            var result = solution.SpiralOrder(input);

            AssertHelper.AssertList(new int[] { 1, 11, 12, 13, 14, 15, 16, 6, 5, 4, 3, 2 }, result);
        }
    }
}
