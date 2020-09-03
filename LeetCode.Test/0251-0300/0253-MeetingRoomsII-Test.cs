using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0253_MeetingRoomsII_Test
    {
        [TestMethod]
        public void MinMeetingRoomsTest_1()
        {
            var solution = new _0253_MeetingRoomsII();
            var result = solution.MinMeetingRooms(
                new int[][]
                {
                    new int[] { 0, 30 },
                    new int[] { 5, 10 },
                    new int[] { 15, 20 },
                }
            );
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinMeetingRoomsTest_2()
        {
            var solution = new _0253_MeetingRoomsII();
            var result = solution.MinMeetingRooms(
                new int[][]
                {
                    new int[] { 7, 10 },
                    new int[] { 2, 4 },
                }
            );
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinMeetingRoomsTest_3()
        {
            var solution = new _0253_MeetingRoomsII();
            var result = solution.MinMeetingRooms(
                new int[][]
                {
                    new int[] { 1, 5 },
                    new int[] { 2, 4 },
                    new int[] { 3, 6 },
                    new int[] { 7, 8 },
                    new int[] { 9, 10 },
                    new int[] { 11, 12 },
                }
            );
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MinMeetingRoomsTest_4()
        {
            var solution = new _0253_MeetingRoomsII();
            var result = solution.MinMeetingRooms(
                new int[][]
                {
                    new int[] { 1, 5 },
                    new int[] { 5, 6 },
                }
            );
            Assert.AreEqual(1, result);
        }
    }
}
