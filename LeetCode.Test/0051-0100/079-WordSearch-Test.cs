using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _079_WordSearch_Test
    {
        [TestMethod]
        public void ExistTest_Exist()
        {
            var input = new char[3][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };

            var solution = new _079_WordSearch();
            var result = solution.Exist(input, "ABCCED");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ExistTest_Exist_2()
        {
            var input = new char[3][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };

            var solution = new _079_WordSearch();
            var result = solution.Exist(input, "SEE");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ExistTest_NotExist()
        {
            var input = new char[3][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };

            var solution = new _079_WordSearch();
            var result = solution.Exist(input, "ABCB");

            Assert.IsFalse(result);
        }
    }
}
