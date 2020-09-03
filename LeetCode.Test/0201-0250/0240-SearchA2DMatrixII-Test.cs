using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0240_SearchA2DMatrixII_Test
    {
        [TestMethod]
        public void SearchMatrixTest_1()
        {
            var input = new int[,]
            {
                { 1, 4, 7, 11, 15 },
                { 2, 5, 8, 12, 19 },
                { 3, 6, 9, 16, 22 },
                { 10, 13, 14, 17, 24 },
                { 18, 21, 23, 26, 30 }
            };

            var solution = new _0240_SearchA2DMatrixII();
            Assert.IsTrue(solution.SearchMatrix(input, 5));
            Assert.IsFalse(solution.SearchMatrix(input, 20));
        }
    }
}
