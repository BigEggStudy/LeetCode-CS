//-----------------------------------------------------------------------------
// Runtime: 216ms
// Memory Usage: 33.5 MB
// Link: https://leetcode.com/submissions/detail/335617325/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0412_FizzBuzz
    {
        public IList<string> FizzBuzz(int n)
        {
            var answer = new List<string>();
            for (int num = 1; num <= n; num++)
            {
                var divisibleBy3 = (num % 3 == 0);
                var divisibleBy5 = (num % 5 == 0);

                var str = string.Empty;
                if (divisibleBy3)
                    str += "Fizz";
                if (divisibleBy5)
                    str += "Buzz";

                if (string.IsNullOrEmpty(str))
                    str = num.ToString();

                answer.Add(str);
            }

            return answer;
        }
    }
}
