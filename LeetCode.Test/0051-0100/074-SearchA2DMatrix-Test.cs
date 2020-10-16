using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _074_SearchA2DMatrix_Test
    {
        [TestMethod]
        public void SearchMatrixTest_Exist_FirstRow()
        {
            var input = new int[][]
            {
                new int[] {  1,  3,  5,  7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 50 }
            };

            var solution = new _074_SearchA2DMatrix();
            var result = solution.SearchMatrix(input, 3);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchMatrixTest_Exist_FirstColumn()
        {
            var input = new int[][]
            {
                new int[] {  1,  3,  5,  7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 50 }
            };

            var solution = new _074_SearchA2DMatrix();
            var result = solution.SearchMatrix(input, 10);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchMatrixTest_Exist_MidRow()
        {
            var input = new int[][]
            {
                new int[] {  1,  3,  5,  7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 50 }
            };

            var solution = new _074_SearchA2DMatrix();
            var result = solution.SearchMatrix(input, 11);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchMatrixTest_Exist_LastRow()
        {
            var input = new int[][]
            {
                new int[] {  1,  3,  5,  7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 50 }
            };

            var solution = new _074_SearchA2DMatrix();
            var result = solution.SearchMatrix(input, 34);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchMatrixTest_NotExist_LessThanFirst()
        {
            var input = new int[][]
            {
                new int[] {  1,  3,  5,  7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 50 }
            };

            var solution = new _074_SearchA2DMatrix();
            var result = solution.SearchMatrix(input, 0);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SearchMatrixTest_NotExist_GreaterThanLast()
        {
            var input = new int[][]
            {
                new int[] {  1,  3,  5,  7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 50 }
            };

            var solution = new _074_SearchA2DMatrix();
            var result = solution.SearchMatrix(input, 51);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SearchMatrixTest_NotExist_GreaterThanFirstRow()
        {
            var input = new int[][]
            {
                new int[] {  1,  3,  5,  7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 50 }
            };

            var solution = new _074_SearchA2DMatrix();
            var result = solution.SearchMatrix(input, 8);

            Assert.IsFalse(result);
        }
    }
}
