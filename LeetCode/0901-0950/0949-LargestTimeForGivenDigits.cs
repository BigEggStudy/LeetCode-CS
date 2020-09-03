//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/358744543/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0949_LargestTimeForGivenDigits
    {
        public string LargestTimeFromDigits(int[] A)
        {
            int ans = -1;

            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                {
                    if (j == i) continue;

                    for (int k = 0; k < 4; ++k)
                    {
                        if (k == i || k == j) continue;

                        int l = 6 - i - j - k;

                        int hours = 10 * A[i] + A[j];
                        int mins = 10 * A[k] + A[l];
                        if (hours < 24 && mins < 60)
                            ans = Math.Max(ans, hours * 60 + mins);
                    }
                }

            return ans >= 0 ? $"{ans / 60:D2}:{ans % 60:D2}" : "";
        }
    }
}
