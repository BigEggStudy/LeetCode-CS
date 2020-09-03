//-----------------------------------------------------------------------------
// Runtime: 424ms
// Memory Usage: 48.5 MB
// Link: https://leetcode.com/submissions/detail/346861360/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0973_KClosestPointsToOrigin
    {
        private readonly Random random = new Random();

        public int[][] KClosest(int[][] points, int K)
        {
            Sort(points, 0, points.Length - 1, K);

            var result = new int[K][];
            Array.Copy(points, 0, result, 0, K);
            return result;
        }

        private void Sort(int[][] points, int lo, int hi, int k)
        {
            if (lo >= hi) return;
            var randomIndex = random.Next(lo, hi);
            Swap(points, lo, randomIndex);

            var mid = Partition(points, lo, hi);
            var length = mid - lo + 1;
            if (length > k)
                Sort(points, lo, mid - 1, k);
            else
                Sort(points, mid + 1, hi, k - length);
        }

        private int Partition(int[][] points, int lo, int hi)
        {
            int i = lo, j = hi + 1;
            var pivotDistance = GetDistance(points, lo);

            while (true)
            {
                while (GetDistance(points, ++i) < pivotDistance) if (i == hi) break;
                while (GetDistance(points, --j) > pivotDistance) if (j == lo) break;
                if (i >= j) break;
                Swap(points, i, j);
            }
            Swap(points, lo, j);
            return j;
        }

        private int GetDistance(int[][] points, int i)
        {
            return points[i][0] * points[i][0] + points[i][1] * points[i][1];
        }

        private void Swap(int[][] points, int i, int j)
        {
            int t0 = points[i][0], t1 = points[i][1];
            points[i][0] = points[j][0];
            points[i][1] = points[j][1];
            points[j][0] = t0;
            points[j][1] = t1;
        }
    }
}
