//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 32.5 MB
// Link: https://leetcode.com/submissions/detail/403607959/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _039_CombinationSum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);

            var result = new List<IList<int>>();
            DeepFirstSearch(candidates, target, 0, new List<int>(), result);
            return result;
        }

        void DeepFirstSearch(int[] candidates, int gap, int startIndex, IList<int> tempResult, IList<IList<int>> result)
        {
            for (int i = startIndex; i < candidates.Length; i++)
            {
                if (candidates[i] > gap) { return; }

                tempResult.Add(candidates[i]);

                if (candidates[i] == gap)
                {
                    result.Add(new List<int>(tempResult));
                }
                else
                {
                    DeepFirstSearch(candidates, gap - candidates[i], i, tempResult, result);
                }
                tempResult.RemoveAt(tempResult.Count - 1);
            }
        }
    }
}
