//-----------------------------------------------------------------------------
// Runtime: 268ms
// Memory Usage: 33.8 MB
// Link: https://leetcode.com/submissions/detail/350029733/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0406_QueueReconstructionByHeight
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            Array.Sort(people, new PeopleComparer());

            var result = new List<int[]>(people.Length);
            foreach (var p in people)
                result.Insert(p[1], p);
            return result.ToArray();
        }

        private class PeopleComparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                return x[0] == y[0] ? x[1].CompareTo(y[1]) : -x[0].CompareTo(y[0]);
            }
        }
    }
}
