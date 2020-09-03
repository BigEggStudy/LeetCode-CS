using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0489_RobotRoomCleaner_Test
    {
        [TestMethod]
        public void CleanRoomTest()
        {
            var grid = new int[][]
            {
                new int[] { 1, 1, 1, 1, 1, 0, 1, 1 },
                new int[] { 1, 1, 1, 1, 1, 0, 1, 1 },
                new int[] { 1, 0, 1, 1, 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            };
            var robot = new Robot(grid, 1, 3);

            var solution = new _0489_RobotRoomCleaner();
            solution.CleanRoom(robot);
            AssertHelper.AssertArray(new bool[5, 8] {
                { true, true, true, true, true, false, true, true },
                { true, true, true, true, true, false, true, true },
                { true, false, true, true, true, true, true, true },
                { false, false, false, true, false, false, false, false },
                { true, true, true, true, true, true, true, true },
            }, robot.CleannedGrid);
        }
    }
}
