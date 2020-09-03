//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 22.9 MB
// Link: https://leetcode.com/submissions/detail/375095783/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0166_FractionToRecurringDecimal
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            if (numerator == 0) return "0";

            StringBuilder sb = new StringBuilder();
            if (numerator < 0 ^ denominator < 0) sb.Append("-");

            long dividend = Math.Abs((long)numerator);
            long divisor = Math.Abs((long)denominator);
            sb.Append((dividend / divisor).ToString());

            long remainder = dividend % divisor;
            if (remainder == 0) return sb.ToString();

            sb.Append('.');
            var map = new Dictionary<long, int>();
            while (remainder != 0)
            {
                if (map.ContainsKey(remainder))
                {
                    sb.Insert(map[remainder], "(");
                    sb.Append(")");
                    break;
                }

                map[remainder] = sb.Length;
                remainder *= 10;
                sb.Append((remainder / divisor).ToString());
                remainder %= divisor;
            }
            return sb.ToString();
        }
    }
}
