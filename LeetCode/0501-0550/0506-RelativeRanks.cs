//-----------------------------------------------------------------------------
// Runtime: 260ms
// Memory Usage: 34.9 MB
// Link: https://leetcode.com/submissions/detail/344770619/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _0506_RelativeRanks
    {
        public string[] FindRelativeRanks(int[] nums)
        {
            var max = nums.Max();
            var index = new int[max + 1];
            for (int i = 0; i < nums.Length; i++)
                index[nums[i]] = i + 1;

            var result = new string[nums.Length];
            var rank = 1;
            for (int i = max; i >= 0; i--)
            {
                if (index[i] != 0)
                {
                    if (rank == 1) result[index[i] - 1] = "Gold Medal";
                    else if (rank == 2) result[index[i] - 1] = "Silver Medal";
                    else if (rank == 3) result[index[i] - 1] = "Bronze Medal";
                    else result[index[i] - 1] = rank.ToString();

                    rank++;
                }
            }

            return result;
        }
    }
}
