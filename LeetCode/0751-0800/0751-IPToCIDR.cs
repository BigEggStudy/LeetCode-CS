//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 32.7 MB
// Link: https://leetcode.com/submissions/detail/335614493/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0751_IPToCIDR
    {
        public IList<string> IpToCIDR(string ip, int n)
        {
            var answer = new List<string>();

            long start = IPToLong(ip);
            while (n > 0)
            {
                int mask = Math.Max(33 - BitLength(LowestOneBit(start)),
                                    33 - BitLength(n));
                answer.Add(LongToIP(start) + "/" + mask);
                start += 1 << (32 - mask);
                n -= 1 << (32 - mask);
            }
            return answer;
        }

        private long IPToLong(string ip)
        {
            long answer = 0;
            foreach (var x in ip.Split('.'))
                answer = 256 * answer + int.Parse(x);

            return answer;
        }

        private int LowestOneBit(long num)
        {
            var str = Convert.ToString(num, 2);
            return (int)Math.Pow(2, str.Length - str.LastIndexOf('1') - 1);
        }

        private string LongToIP(long x)
        {
            return $"{x >> 24}.{(x >> 16) % 256}.{(x >> 8) % 256}.{x % 256}";
        }

        private int BitLength(long x)
        {
            if (x == 0) return 1;

            int count = 0;
            while (x > 0)
            {
                x >>= 1;
                count++;
            }
            return count;
        }
    }
}
