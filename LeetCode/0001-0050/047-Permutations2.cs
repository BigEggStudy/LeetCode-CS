//-----------------------------------------------------------------------------
// Runtime: 492ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _047_Permutations2
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var result = new List<IList<int>>();
            result.Add(nums);

            int length = nums.Length;
            int size, temp, i, j, k;
            int[] tempArray;
            IList<int> tempList;
            for (i = 0; i < length; i++)
            {
                size = result.Count;
                for (j = 0; j < size; j++)
                {
                    tempArray = result[j].ToArray();
                    Array.Sort(tempArray, i, length - i);
                    result[j] = tempArray;
                    for (k = i + 1; k < length; k++)
                    {
                        tempList = new List<int>(result[j]);
                        if (tempList[k] == tempList[k - 1] ||
                            tempList[k] == tempList[i])
                        { continue; }

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
