//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 31.8 MB
// Link: https://leetcode.com/submissions/detail/319930583/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0283_MoveZeroes
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return;

            int cur = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != 0)
                    nums[cur++] = nums[i];

            for (; cur < nums.Length; cur++)
                nums[cur] = 0;
        }
    }
}
