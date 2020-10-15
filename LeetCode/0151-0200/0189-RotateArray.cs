//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 32.8 MB
// Link: https://leetcode.com/submissions/detail/409217846/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0189_RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            if (k >= nums.Length)
                k %= nums.Length;

            for (int start = 0, count = 0; start < k && count < nums.Length; start++)
            {
                int curr = start;
                var prev = nums[curr];
                do
                {
                    var next = curr + k;
                    if (next >= nums.Length)
                        next -= nums.Length;

                    var temp = nums[next];
                    nums[next] = prev;
                    prev = temp;
                    curr = next;

                    count++;
                } while (start != curr);
            }
        }
    }
}
