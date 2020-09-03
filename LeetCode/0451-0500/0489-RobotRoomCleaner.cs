//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    /**
     * // This is the robot's control interface.
     * // You should not implement it, or speculate about its implementation
     * interface Robot {
     *     // Returns true if the cell in front is open and robot moves into the cell.
     *     // Returns false if the cell in front is blocked and robot stays in the current cell.
     *     public bool Move();
     *
     *     // Robot will stay in the same cell after calling turnLeft/turnRight.
     *     // Each turn will be 90 degrees.
     *     public void TurnLeft();
     *     public void TurnRight();
     *
     *     // Clean the current cell.
     *     public void Clean();
     * }
     */
    public class _0489_RobotRoomCleaner
    {
        private readonly int[][] directions = { new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 } };


        public void CleanRoom(Robot robot)
        {
            var visited = new HashSet<Position>();
            CleanRoom(robot, 0, 0, 0, visited);
        }

        private void CleanRoom(Robot robot, int row, int col, int direction, HashSet<Position> visited)
        {
            visited.Add(new Position(row, col));
            robot.Clean();
            for (int turn = 0; turn < 4; turn++)
            {
                var newDirection = (direction + turn) % 4;
                int newRow = row + directions[newDirection][0];
                int newCol = col + directions[newDirection][1];

                if (!visited.Contains(new Position(newRow, newCol)) && robot.Move())
                {
                    CleanRoom(robot, newRow, newCol, newDirection, visited);
                    TurnBack(robot);
                }

                robot.TurnRight();
            }
        }

        private void TurnBack(Robot robot)
        {
            robot.TurnRight();
            robot.TurnRight();
            robot.Move();
            robot.TurnRight();
            robot.TurnRight();
        }
    }

    public class Position : IComparable<Position>, IEquatable<Position>
    {
        public Position(int row, int col)
        {
            Row = row;
            Column = col;
        }

        public int Row { get; set; }

        public int Column { get; set; }

        public int CompareTo(Position other)
        {
            var result = Row.CompareTo(other.Row);
            if (result == 0)
                return Column.CompareTo(other.Column);
            else
                return result;
        }

        public bool Equals(Position other)
        {
            return Row == other.Row && Column == other.Column;
        }

        public override int GetHashCode()
        {
            return Row.GetHashCode() ^ Column.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Position)) return Equals((Position)obj);
            else return false;
        }
    }

    public class Robot
    {
        private readonly int[][] grid;
        private readonly bool[,] cleannedGrid;
        private int current_row;
        private int current_col;
        private int direction = 0;

        private readonly int[][] directions = { new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 } };

        public Robot(int[][] grid, int row, int col)
        {
            this.grid = grid;
            this.current_row = row;
            this.current_col = col;

            this.cleannedGrid = new bool[grid.Length, grid[0].Length];
        }

        public bool[,] CleannedGrid { get { return cleannedGrid; } }

        public bool Move()
        {
            int newRow = current_row + directions[direction][0];
            int newCol = current_col + directions[direction][1];

            if ((newRow >= 0 && newRow < grid.Length) && (newCol >= 0 && newCol < grid[0].Length) && grid[newRow][newCol] == 1)
            {
                current_row = newRow;
                current_col = newCol;
                return true;
            }
            return false;
        }

        public void TurnLeft()
        {
            direction = (direction - 1 + 4) % 4;
        }

        public void TurnRight()
        {
            direction = (direction + 1) % 4;
        }

        public void Clean()
        {
            cleannedGrid[current_row, current_col] = true;
        }
    }
}
