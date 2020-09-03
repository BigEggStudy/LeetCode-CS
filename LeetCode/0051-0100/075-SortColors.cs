//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 29.9 MB
// Link: https://leetcode.com/submissions/detail/352305485/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _075_SortColors
    {
        public void SortColors(int[] nums)
        {
            int lt = 0, gt = nums.Length - 1, i = 0, temp;
            while (i <= gt)
            {
                if (nums[i] == 0)
                {
                    temp = nums[lt];
                    nums[lt++] = nums[i];
                    nums[i++] = temp;
                }
                else if (nums[i] == 2)
                {
                    nums[i] = nums[gt];
                    nums[gt--] = 2;
                }
                else
                {
                    i++;
                }
            }
        }

        public void SortColors_2(int[] nums)
        {
            var counts = new int[3] { 0, 0, 0 };
            int i, j;
            for (i = 0; i < nums.Length; i++)
                counts[nums[i]]++;

            int index = 0;
            for (i = 0; i < 3; i++)
                for (j = 0; j < counts[i]; j++)
                    nums[index++] = i;
        }
    }
}
