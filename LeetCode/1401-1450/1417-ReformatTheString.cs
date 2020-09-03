//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/340997010/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _1417_ReformatTheString
    {
        public string Reformat(string s)
        {
            var letterQueue = new Queue<char>();
            var digitQueue = new Queue<char>();

            foreach (var ch in s)
            {
                if (char.IsLetter(ch))
                    letterQueue.Enqueue(ch);
                else
                    digitQueue.Enqueue(ch);
            }

            var different = letterQueue.Count - digitQueue.Count;
            if (different > 1 || different < -1)
                return string.Empty;

            var sb = new StringBuilder();
            if (different == 1)
                sb.Append(letterQueue.Dequeue());

            while (letterQueue.Count > 0)
            {
                sb.Append(digitQueue.Dequeue());
                sb.Append(letterQueue.Dequeue());
            }

            if (digitQueue.Count > 0)
                sb.Append(digitQueue.Dequeue());

            return sb.ToString();
        }
    }
}
