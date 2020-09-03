//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.3 MB
// Link: https://leetcode.com/submissions/detail/342539937/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1184_DistanceBetweenBusStops
    {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            if (start > destination)
            {
                var temp = start;
                start = destination;
                destination = temp;
            }

            int dist1 = 0, dist2 = 0;
            for (int i = 0; i < distance.Length; i++)
            {
                if (i >= start && i < destination) dist2 += distance[i];
                else dist1 += distance[i];
            }

            return Math.Min(dist1, dist2);
        }
    }
}
