//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 28.8 MB
// Link: https://leetcode.com/submissions/detail/261553087/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0169_MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0, candidate = 0;
            foreach (var num in nums)
            {
                if (count == 0) candidate = num;
                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
        }
    }
}
