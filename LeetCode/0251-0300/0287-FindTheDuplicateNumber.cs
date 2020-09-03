//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 24.5 MB
// Link: https://leetcode.com/submissions/detail/261902358/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0287_FindTheDuplicateNumber
    {
        public int FindDuplicate(int[] nums)
        {
            int tortoise = nums[0], hare = nums[0];
            do
            {
                tortoise = nums[tortoise];
                hare = nums[nums[hare]];
            } while (tortoise != hare);

            int ptr1 = nums[0], ptr2 = tortoise;
            while (ptr1 != ptr2)
            {
                ptr1 = nums[ptr1];
                ptr2 = nums[ptr2];
            }

            return ptr1;
        }
    }
}
