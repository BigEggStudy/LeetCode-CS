using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1011_CapacityToShipPackagesWithinDDays_Test
    {
        [TestMethod]
        public void ShipWithinDaysTeset_1()
        {
            var solution = new _1011_CapacityToShipPackagesWithinDDays();
            var result = solution.ShipWithinDays(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void ShipWithinDaysTeset_2()
        {
            var solution = new _1011_CapacityToShipPackagesWithinDDays();
            var result = solution.ShipWithinDays(new int[] { 3, 2, 2, 4, 1, 4 }, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void ShipWithinDaysTeset_3()
        {
            var solution = new _1011_CapacityToShipPackagesWithinDDays();
            var result = solution.ShipWithinDays(new int[] { 1, 2, 3, 1, 1 }, 4);
            Assert.AreEqual(3, result);
        }
    }
}
