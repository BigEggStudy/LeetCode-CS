//-----------------------------------------------------------------------------
// Runtime: 216ms
// Memory Usage: 37.7 MB
// Link: https://leetcode.com/submissions/detail/359235046/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0874_WalkingRobotSimulation
    {
        public int RobotSim(int[] commands, int[][] obstacles)
        {
            int[] dx = new int[] { 0, 1, 0, -1 }, dy = new int[] { 1, 0, -1, 0 };
            int x = 0, y = 0, dir = 0;

            var obstacleSet = new HashSet<int>();
            foreach (var obstacle in obstacles)
                obstacleSet.Add((obstacle[0] << 16) + obstacle[1]);

            var result = 0;
            foreach (var cmd in commands)
            {
                if (cmd == -2) dir = (dir + 3) % 4;
                else if (cmd == -1) dir = (dir + 1) % 4;
                else
                {
                    for (int i = 0; i < cmd; i++)
                    {
                        var nx = x + dx[dir];
                        var ny = y + dy[dir];

                        if (obstacleSet.Contains((nx << 16) + ny))
                            break;

                        x = nx;
                        y = ny;
                    }
                }

                result = Math.Max(result, x * x + y * y);
            }

            return result;
        }
    }
}
