//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 30.1 MB
// Link: https://leetcode.com/submissions/detail/379552144/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _088_MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            m--;
            n--;
            for (var i = m + n + 1; i >= 0; i--)
            {
                if (m >= 0 && n >= 0)
                    if (nums1[m] >= nums2[n]) nums1[i] = nums1[m--];
                    else nums1[i] = nums2[n--];
                else if (n >= 0)
                    nums1[i] = nums2[n--];
            }
        }
    }
}
