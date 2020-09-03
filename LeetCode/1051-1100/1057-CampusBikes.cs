//-----------------------------------------------------------------------------
// Runtime: 452ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1057_CampusBikes
    {
        public int[] AssignBikes(int[][] workers, int[][] bikes)
        {
            var distanceMap = new Dictionary<int, List<Tuple<int, int>>>();
            for (var i = 0; i < workers.Length; i++)
                for (var j = 0; j < bikes.Length; j++)
                {
                    var distance = ManhattanDistance(workers[i], bikes[j]);
                    if (distanceMap.ContainsKey(distance))
                        distanceMap[distance].Add(new Tuple<int, int>(i, j));
                    else
                        distanceMap.Add(distance, new List<Tuple<int, int>>() { new Tuple<int, int>(i, j) });
                }

            var keys = distanceMap.Keys.OrderBy(key => key);
            var usedBike = new HashSet<int>();
            var result = new int[workers.Length];
            for (int i = 0; i < workers.Length; i++)
                result[i] = -1;

            foreach (var key in keys)
            {
                var pairs = distanceMap[key];
                foreach (var pair in pairs)
                {
                    var workerId = pair.Item1;
                    var bikeId = pair.Item2;
                    if (result[workerId] == -1 && !usedBike.Contains(bikeId))
                    {
                        result[workerId] = bikeId;
                        usedBike.Add(bikeId);
                    }
                }
            }

            return result;
        }

        public int ManhattanDistance(int[] worker, int[] bike)
        {
            return Math.Abs(worker[0] - bike[0]) + Math.Abs(worker[1] - bike[1]);
        }
    }
}
