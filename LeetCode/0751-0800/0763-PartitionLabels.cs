//-----------------------------------------------------------------------------
// Runtime: 224ms
// Memory Usage: 30.6 MB
// Link: https://leetcode.com/submissions/detail/391038298/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0763_PartitionLabels
    {
        public IList<int> PartitionLabels(string S)
        {
            int[] last = new int[26];
            for (int i = 0; i < S.Length; i++)
                last[S[i] - 'a'] = i;

            int start = 0, lastMax = 0;
            var result = new List<int>();
            for (int i = 0; i < S.Length; i++)
            {
                lastMax = Math.Max(lastMax, last[S[i] - 'a']);
                if (i == lastMax)
                {
                    result.Add(i - start + 1);
                    start = lastMax + 1;
                }
            }
            return result;
        }
    }
}
