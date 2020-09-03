//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 22.9 MB
// Link: https://leetcode.com/submissions/detail/363015170/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0537_ComplexNumberMultiplication
    {
        public string ComplexNumberMultiply(string a, string b)
        {
            var split1 = a.Split(new char[] { '+', 'i' }, StringSplitOptions.RemoveEmptyEntries);
            var split2 = b.Split(new char[] { '+', 'i' }, StringSplitOptions.RemoveEmptyEntries);

            int a1 = int.Parse(split1[0]), b1 = int.Parse(split1[1]);
            int a2 = int.Parse(split2[0]), b2 = int.Parse(split2[1]);

            return $"{a1 * a2 - b1 * b2}+{a1 * b2 + a2 * b1}i";
        }
    }
}
