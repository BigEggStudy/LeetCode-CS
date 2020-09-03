using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0252_MeetingRooms_Test
    {
        [TestMethod]
        public void CanAttendMeetings_1()
        {
            var solution = new _0252_MeetingRooms();
            var result = solution.CanAttendMeetings(new int[][] {
                new int[] { 0, 30 },
                new int[] { 5, 10 },
                new int[] { 15, 20 },
            });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanAttendMeetings_2()
        {
            var solution = new _0252_MeetingRooms();
            var result = solution.CanAttendMeetings(new int[][] {
                new int[] { 7, 10 },
                new int[] { 2, 4 },
            });
            Assert.IsTrue(result);
        }
    }
}
