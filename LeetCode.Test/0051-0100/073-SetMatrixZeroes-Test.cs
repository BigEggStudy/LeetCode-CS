using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _073_SetMatrixZeroes_Test
    {
        [TestMethod]
        public void SetZeroesTest_NoZero()
        {
            var input = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            }, input);
        }

        [TestMethod]
        public void SetZeroesTest_HasZero()
        {
            var input = new int[,]
            {
                { 1, 2, 3 },
                { 4, 0, 6 },
                { 7, 8, 9 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 1, 0, 3 },
                { 0, 0, 0 },
                { 7, 0, 9 }
            }, input);
        }

        [TestMethod]
        public void SetZeroesTest_HasZero_FirstRow()
        {
            var input = new int[,]
            {
                { 1, 0, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 0, 0, 0 },
                { 4, 0, 6 },
                { 7, 0, 9 }
            }, input);
        }

        [TestMethod]
        public void SetZeroesTest_HasZero_FirstColumn()
        {
            var input = new int[,]
            {
                { 1, 2, 3 },
                { 0, 5, 6 },
                { 7, 8, 9 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 0, 2, 3 },
                { 0, 0, 0 },
                { 0, 8, 9 }
            }, input);
        }

        [TestMethod]
        public void SetZeroesTest_HasZero_TopLeft()
        {
            var input = new int[,]
            {
                { 0, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 0, 0, 0 },
                { 0, 5, 6 },
                { 0, 8, 9 }
            }, input);
        }

        [TestMethod]
        public void SetZeroesTest_HasZero_Multiple()
        {
            var input = new int[,]
            {
                { 1, 2, 3, 4 },
                { 4, 0, 6, 7 },
                { 7, 8, 0, 10 },
                { 10, 11, 12, 13 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 1, 0, 0, 4 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 10, 0, 0, 13 }
            }, input);
        }


        [TestMethod]
        public void SetZeroes_2Test_NoZero()
        {
            var input = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes_2(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            }, input);
        }

        [TestMethod]
        public void SetZeroes_2Test_HasZero()
        {
            var input = new int[,]
            {
                { 1, 2, 3 },
                { 4, 0, 6 },
                { 7, 8, 9 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes_2(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 1, 0, 3 },
                { 0, 0, 0 },
                { 7, 0, 9 }
            }, input);
        }

        [TestMethod]
        public void SetZeroes_2Test_HasZero_FirstRow()
        {
            var input = new int[,]
            {
                { 1, 0, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes_2(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 0, 0, 0 },
                { 4, 0, 6 },
                { 7, 0, 9 }
            }, input);
        }

        [TestMethod]
        public void SetZeroes_2Test_HasZero_FirstColumn()
        {
            var input = new int[,]
            {
                { 1, 2, 3 },
                { 0, 5, 6 },
                { 7, 8, 9 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes_2(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 0, 2, 3 },
                { 0, 0, 0 },
                { 0, 8, 9 }
            }, input);
        }

        [TestMethod]
        public void SetZeroes_2Test_HasZero_TopLeft()
        {
            var input = new int[,]
            {
                { 0, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes_2(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 0, 0, 0 },
                { 0, 5, 6 },
                { 0, 8, 9 }
            }, input);
        }

        [TestMethod]
        public void SetZeroes_2Test_HasZero_Multiple()
        {
            var input = new int[,]
            {
                { 1, 2, 3, 4 },
                { 4, 0, 6, 7 },
                { 7, 8, 0, 10 },
                { 10, 11, 12, 13 }
            };

            var solution = new _073_SetMatrixZeroes();
            solution.SetZeroes_2(input);

            AssertHelper.AssertMatrix(new int[,]
            {
                { 1, 0, 0, 4 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 10, 0, 0, 13 }
            }, input);
        }
    }
}
