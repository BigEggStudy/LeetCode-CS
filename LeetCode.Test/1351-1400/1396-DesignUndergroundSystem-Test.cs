using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1396_DesignUndergroundSystem_Test
    {
        [TestMethod]
        public void UndergroundSystemTest_1()
        {
            var undergroundSystem = new _1396_DesignUndergroundSystem();

            undergroundSystem.CheckIn(45, "Leyton", 3);
            undergroundSystem.CheckIn(32, "Paradise", 8);
            undergroundSystem.CheckIn(27, "Leyton", 10);
            undergroundSystem.CheckOut(45, "Waterloo", 15);
            undergroundSystem.CheckOut(27, "Waterloo", 20);
            undergroundSystem.CheckOut(32, "Cambridge", 22);
            Assert.AreEqual(14.0, undergroundSystem.GetAverageTime("Paradise", "Cambridge"));
            Assert.AreEqual(11.0, undergroundSystem.GetAverageTime("Leyton", "Waterloo"));
            undergroundSystem.CheckIn(10, "Leyton", 24);
            Assert.AreEqual(11.0, undergroundSystem.GetAverageTime("Leyton", "Waterloo"));
            undergroundSystem.CheckOut(10, "Waterloo", 38);
            Assert.AreEqual(12.0, undergroundSystem.GetAverageTime("Leyton", "Waterloo"));
        }

        [TestMethod]
        public void UndergroundSystemTest_2()
        {
            var undergroundSystem = new _1396_DesignUndergroundSystem();

            undergroundSystem.CheckIn(10, "Leyton", 3);
            undergroundSystem.CheckOut(10, "Paradise", 8);
            Assert.AreEqual(5.0, undergroundSystem.GetAverageTime("Leyton", "Paradise"));
            undergroundSystem.CheckIn(5, "Leyton", 10);
            undergroundSystem.CheckOut(5, "Paradise", 16);
            Assert.AreEqual(5.5, undergroundSystem.GetAverageTime("Leyton", "Paradise"));
            undergroundSystem.CheckIn(2, "Leyton", 21);
            undergroundSystem.CheckOut(2, "Paradise", 30);
            Assert.AreEqual(6.66667, undergroundSystem.GetAverageTime("Leyton", "Paradise"), 0.00001);
        }
    }
}
