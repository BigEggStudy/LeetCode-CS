//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 22.6 MB
// Link: https://leetcode.com/submissions/detail/393499359/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0165_CompareVersionNumbers
    {
        public int CompareVersion(string version1, string version2)
        {
            var nums1 = version1.Split(new char[] { '.' });
            var nums2 = version2.Split(new char[] { '.' });

            var length1 = nums1.Length;
            var length2 = nums2.Length;

            for (int i = 0; i < Math.Max(length1, length2); i++)
            {
                var current1 = i < length1 ? int.Parse(nums1[i]) : 0;
                var current2 = i < length2 ? int.Parse(nums2[i]) : 0;
                if (current1 != current2)
                    return current1 > current2 ? 1 : -1;
            }

            return 0;
        }
    }
}
