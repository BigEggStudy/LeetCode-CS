//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1066_CampusBikesII
    {
        public int AssignBikes(int[][] workers, int[][] bikes)
        {
            int[] memory = new int[1 << bikes.Length];
            return DFS(0, workers, bikes, 0, memory);
        }

        private int DFS(int currentWorker, int[][] workers, int[][] bikes, int visited, int[] memory)
        {
            if (currentWorker == workers.Length) return 0;
            if (memory[visited] > 0) return memory[visited];

            var answer = int.MaxValue;
            for (int i = 0; i < bikes.Length; i++)
                if ((visited & 1 << i) == 0)
                {
                    visited |= 1 << i;
                    answer = Math.Min(answer, ManhattanDistance(workers[currentWorker], bikes[i]) + DFS(currentWorker + 1, workers, bikes, visited, memory));
                    visited &= ~(1 << i);
                }

            memory[visited] = answer;
            return answer;
        }

        private int ManhattanDistance(int[] worker, int[] bike)
        {
            return Math.Abs(worker[0] - bike[0]) + Math.Abs(worker[1] - bike[1]);
        }
    }
}
