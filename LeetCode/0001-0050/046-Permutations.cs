//-----------------------------------------------------------------------------
// Runtime: 492ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _046_Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            result.Add(nums);

            int length = nums.Length;
            int size, temp, i, j, k;
            IList<int> tempList;
            for (i = 0; i < length; i++)
            {
                size = result.Count;
                for (j = 0; j < size; j++)
                {
                    for (k = i + 1; k < length; k++)
                    {
                        tempList = new List<int>(result[j]);
                        temp = tempList[k];
                        tempList[k] = tempList[i];
                        tempList[i] = temp;
                        result.Add(tempList);
                    }
                }
            }

            return result;
        }
    }
}
