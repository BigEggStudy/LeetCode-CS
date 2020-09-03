//-----------------------------------------------------------------------------
// Runtime: 384ms
// Memory Usage: 48.6 MB
// Link: https://leetcode.com/submissions/detail/351853474/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1042_FlowerPlantingWithNoAdjacent
    {
        public int[] GardenNoAdj(int N, int[][] paths)
        {
            var edges = new Dictionary<int, IList<int>>();
            for (int i = 0; i < N; i++)
                edges[i] = new List<int>();
            foreach (var path in paths)
            {
                edges[path[0] - 1].Add(path[1] - 1);
                edges[path[1] - 1].Add(path[0] - 1);
            }

            var results = new int[N];
            for (int i = 0; i < N; i++)
            {
                var usedColor = new bool[5];
                foreach (var v in edges[i])
                    usedColor[results[v]] = true;

                for (int c = 1; c <= 4; c++)
                    if (!usedColor[c])
                    {
                        results[i] = c;
                        break;
                    }
            }

            return results;
        }
    }
}
