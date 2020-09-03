using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1357_ApplyDiscountEveryNOrders_Test
    {
        [TestMethod]
        public void ApplyDiscountEveryNOrders_1()
        {
            var cashier = new _1357_ApplyDiscountEveryNOrders(3, 50, new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 100, 200, 300, 400, 300, 200, 100 });

            Assert.AreEqual(500.0, cashier.GetBill(new int[] { 1, 2 }, new int[] { 1, 2 }));
            Assert.AreEqual(4000.0, cashier.GetBill(new int[] { 3, 7 }, new int[] { 10, 10 }));
            Assert.AreEqual(800.0, cashier.GetBill(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 1, 1, 1, 1, 1, 1 }));
            Assert.AreEqual(4000.0, cashier.GetBill(new int[] { 4 }, new int[] { 10 }));
            Assert.AreEqual(4000.0, cashier.GetBill(new int[] { 7, 3 }, new int[] { 10, 10 }));
            Assert.AreEqual(7350.0, cashier.GetBill(new int[] { 7, 5, 3, 1, 6, 4, 2 }, new int[] { 10, 10, 10, 9, 9, 9, 7 }));
            Assert.AreEqual(2500.0, cashier.GetBill(new int[] { 2, 3, 5 }, new int[] { 5, 3, 2 }));
        }
    }
}
