//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 27.1 MB
// Link: https://leetcode.com/submissions/detail/328251880/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    /**
     * // This is BinaryMatrix's API interface.
     * // You should not implement it, or speculate about its implementation
     * class BinaryMatrix {
     *     public int Get(int x, int y) {}
     *     public IList<int> Dimensions() {}
     * }
     */

    public class _1428_LeftmostColumnWithAtLeastAOne
    {
        public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        {
            var dimensions = binaryMatrix.Dimensions();

            var row = 0;
            var col = dimensions[1] - 1;

            while (row < dimensions[0])
            {
                while (col >= 0 && binaryMatrix.Get(row, col) == 1) col--;
                row++;
            }

            return col + 1 == dimensions[1] ? -1 : col + 1;
        }

        public class BinaryMatrix
        {
            private readonly int[][] numbers;
            private int getCounts = 0;
            private int n = 0;
            private int m = 0;

            public BinaryMatrix(int[][] num)
            {
                numbers = num;
                getCounts = 0;

                n = num.Length;
                m = num[0].Length;
            }

            public int Get(int x, int y)
            {
                if (x < 0 || x >= n) throw new ArgumentException(nameof(x));
                if (y < 0 || y >= m) throw new ArgumentException(nameof(y));
                if (getCounts > 1000) throw new NotSupportedException("Wrong Anser");

                return numbers[x][y];
            }

            public IList<int> Dimensions()
            {
                return new List<int>() { n, m };
            }
        }
    }
}
