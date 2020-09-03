//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 31.1 MB
// Link: https://leetcode.com/submissions/detail/351930109/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0401_BinaryWatch
    {
        public IList<string> ReadBinaryWatch(int num)
        {
            var results = new List<string>();

            for (int i = 0; i < 720; i++)
            {
                int hour = i / 60;
                int minute = i % 60;

                if (BitCount(hour) + BitCount(minute) == num)
                    results.Add($"{hour}:{minute:00}");
            }

            return results;
        }

        private static int BitCount(int num)
        {
            var result = 0;
            while (num > 0)
            {
                result++;
                num &= num - 1;
            }

            return result;
        }
    }
}
