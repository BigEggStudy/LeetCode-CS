//-----------------------------------------------------------------------------
// Runtime: 724ms
// Memory Usage: 63.8 MB
// Link: https://leetcode.com/submissions/detail/364017009/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1357_ApplyDiscountEveryNOrders
    {
        private readonly IDictionary<int, int> productsPrice;
        private readonly int discount;
        private readonly int discountCustomer;
        private int currentCustomerCount;

        public _1357_ApplyDiscountEveryNOrders(int n, int discount, int[] products, int[] prices)
        {
            this.discount = discount;
            this.discountCustomer = n;
            this.currentCustomerCount = 0;

            productsPrice = new Dictionary<int, int>();
            for (int i = 0; i < products.Length; i++)
                productsPrice[products[i]] = prices[i];
        }

        public double GetBill(int[] product, int[] amount)
        {
            var total = 0.0;

            for (int i = 0; i < product.Length; i++)
                total += productsPrice[product[i]] * amount[i];

            currentCustomerCount++;
            if (currentCustomerCount == discountCustomer)
            {
                currentCustomerCount = 0;
                total -= discount / 100.0 * total;
            }

            return total;
        }
    }

    /**
     * Your Cashier object will be instantiated and called as such:
     * Cashier obj = new Cashier(n, discount, products, prices);
     * double param_1 = obj.GetBill(product,amount);
     */
}
