using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _036_ValidSudoku_Test
    {
        [TestMethod]
        public void IsValidSudokuTest()
        {
            var input = new char[9, 9]
            {
                { '5','3','.','.','7','.','.','.','.'},
                { '6','.','.','1','9','5','.','.','.'},
                { '.','9','8','.','.','.','.','6','.'},
                { '8','.','.','.','6','.','.','.','3'},
                { '4','.','.','8','.','3','.','.','1'},
                { '7','.','.','.','2','.','.','.','6'},
                { '.','6','.','.','.','.','2','8','.'},
                { '.','.','.','4','1','9','.','.','5'},
                { '.','.','.','.','8','.','.','7','9'}
            };
            var solution = new _036_ValidSudoku();
            var result = solution.IsValidSudoku(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidSudokuTest_ColumnNotValid()
        {
            var input = new char[9, 9]
            {
                { '5','3','.','.','7','.','.','.','.'},
                { '6','.','.','1','9','5','.','.','.'},
                { '.','9','8','.','.','.','.','6','.'},
                { '8','.','.','.','6','.','.','.','3'},
                { '4','.','.','8','.','3','.','.','1'},
                { '7','.','.','.','2','.','.','.','6'},
                { '.','6','.','.','.','.','2','8','.'},
                { '.','.','.','4','1','9','.','6','5'},
                { '.','.','.','.','8','.','.','7','9'}
            };
            var solution = new _036_ValidSudoku();
            var result = solution.IsValidSudoku(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidSudokuTest_RowNotValid()
        {
            var input = new char[9, 9]
            {
                { '5','3','.','.','7','.','.','.','.'},
                { '6','.','.','1','9','5','.','.','.'},
                { '.','9','8','.','.','.','.','6','.'},
                { '8','.','.','.','6','.','.','.','3'},
                { '4','.','.','8','.','3','.','3','1'},
                { '7','.','.','.','2','.','.','.','6'},
                { '.','6','.','.','.','.','2','8','.'},
                { '.','.','.','4','1','9','.','.','5'},
                { '.','.','.','.','8','.','.','7','9'}
            };
            var solution = new _036_ValidSudoku();
            var result = solution.IsValidSudoku(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidSudokuTest_SqureNotValid()
        {
            var input = new char[9, 9]
            {
                { '5','3','.','.','7','.','.','.','.'},
                { '6','.','.','1','9','5','.','.','.'},
                { '.','9','8','5','.','.','.','6','.'},
                { '8','.','.','.','6','.','.','.','3'},
                { '4','.','.','8','.','3','.','.','1'},
                { '7','.','.','.','2','.','.','.','6'},
                { '.','6','.','.','.','.','2','8','.'},
                { '.','.','.','4','1','9','.','.','5'},
                { '.','.','.','.','8','.','.','7','9'}
            };
            var solution = new _036_ValidSudoku();
            var result = solution.IsValidSudoku(input);

            Assert.IsFalse(result);
        }
    }
}
