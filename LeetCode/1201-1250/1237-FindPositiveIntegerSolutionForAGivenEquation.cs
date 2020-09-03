//-----------------------------------------------------------------------------
// Runtime: 196ms
// Memory Usage: 25.6 MB
// Link: https://leetcode.com/submissions/detail/330138747/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    /*
     * // This is the custom function interface.
     * // You should not implement it, or speculate about its implementation
     * public class CustomFunction {
     *     // Returns f(x, y) for any given positive integers x and y.
     *     // Note that f(x, y) is increasing with respect to both x and y.
     *     // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
     *     public int f(int x, int y);
     * };
     */

    public class _1237_FindPositiveIntegerSolutionForAGivenEquation
    {
        public IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
        {
            var solutions = new List<IList<int>>();

            int minX = MinX(customfunction, z);
            int maxX = MaxX(customfunction, z);

            for (int x = minX; x <= maxX; x++)
            {
                var solution = BinarySearchY(customfunction, x, z);
                if (solution != null)
                    solutions.Add(solution);
            }

            return solutions;
        }

        private int MinX(CustomFunction customfunction, int z)
        {
            int min = 1;
            int max = 1000;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                int fMid = customfunction.f(mid, 1000);
                if (fMid == z)
                    return mid;

                if (fMid < z)
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            return min;
        }

        private int MaxX(CustomFunction customfunction, int z)
        {
            int min = 1;
            int max = 1000;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                int fMid = customfunction.f(mid, 1);
                if (fMid == z)
                    return mid;

                if (fMid < z)
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            return max;
        }

        private IList<int> BinarySearchY(CustomFunction customfunction, int x, int z)
        {
            int min = 1;
            int max = 1000;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                int fMid = customfunction.f(x, mid);
                if (fMid == z)
                    return new int[] { x, mid };

                if (fMid < z)
                    min = mid + 1;
                else
                    max = mid - 1;
            }

            return null;
        }

        public class CustomFunction
        {
            private Func<int, int, int> func;

            public CustomFunction(Func<int, int, int> func)
            {
                this.func = func;
            }

            // Returns f(x, y) for any given positive integers x and y.
            // Note that f(x, y) is increasing with respect to both x and y.
            // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
            public int f(int x, int y)
            {
                return func(x, y);
            }
        };
    }
}
