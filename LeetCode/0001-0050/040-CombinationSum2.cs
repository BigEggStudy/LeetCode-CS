//-----------------------------------------------------------------------------
// Runtime: 484ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _040_CombinationSum2
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);

            var result = new List<IList<int>>();
            DeepFirstSearch(candidates, target, 0, new List<int>(), result);
            return result;
        }

        void DeepFirstSearch(int[] candidates, int gap, int startIndex, IList<int> tempResult, IList<IList<int>> result)
        {
            int previous = -1;
            for (int i = startIndex; i < candidates.Length; i++)
            {
                if (candidates[i] == previous) { continue; }
                if (candidates[i] > gap) { return; }

                previous = candidates[i];
                tempResult.Add(candidates[i]);

                if (candidates[i] == gap)
                {
                    result.Add(new List<int>(tempResult));
                }
                else
                {
                    DeepFirstSearch(candidates, gap - candidates[i], i + 1, tempResult, result);
                }
                tempResult.RemoveAt(tempResult.Count - 1);
            }
        }
    }
}
