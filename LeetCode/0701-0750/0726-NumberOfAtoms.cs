//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 23.3 MB
// Link: https://leetcode.com/submissions/detail/381919537/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _0726_NumberOfAtoms
    {
        public string CountOfAtoms(string formula)
        {
            var map = Parser(formula, 0, formula.Length);

            var sb = new StringBuilder();
            foreach (var key in map.Keys.OrderBy(k => k))
            {
                sb.Append(key);
                if (map[key] > 1)
                    sb.Append(map[key]);
            }

            return sb.ToString();
        }

        private IDictionary<string, int> Parser(string formula, int start, int end)
        {
            var results = new Dictionary<string, int>();

            var count = 0;
            var atom = string.Empty;
            for (int i = start; i < end; i++)
            {
                var ch = formula[i];
                if (char.IsDigit(ch))
                    count = count * 10 + ch - '0';
                else if (char.IsLower(ch))
                    atom += ch;
                else if (char.IsUpper(ch))
                {
                    if (atom != string.Empty)
                    {
                        if (results.ContainsKey(atom))
                            results[atom] += count == 0 ? 1 : count;
                        else
                            results[atom] = count == 0 ? 1 : count;
                    }
                    atom = ch.ToString();
                    count = 0;
                }
                else if (ch == '(')
                {
                    if (atom != string.Empty)
                    {
                        if (results.ContainsKey(atom))
                            results[atom] += count == 0 ? 1 : count;
                        else
                            results[atom] = count == 0 ? 1 : count;
                    }
                    atom = string.Empty;
                    count = 0;

                    var balance = 1;
                    var j = i;
                    while (balance != 0)
                    {
                        j++;
                        if (formula[j] == '(')
                            balance++;
                        else if (formula[j] == ')')
                            balance--;
                    }
                    var map = Parser(formula, i + 1, j);
                    i = j;
                    while (++i < end && char.IsDigit(formula[i]))
                        count = count * 10 + formula[i] - '0';
                    i--;

                    foreach (var key in map.Keys)
                    {
                        if (results.ContainsKey(key))
                            results[key] += map[key] * count;
                        else
                            results[key] = map[key] * count;
                    }
                    count = 0;
                }
            }

            if (atom != string.Empty)
            {
                if (results.ContainsKey(atom))
                    results[atom] += count == 0 ? 1 : count;
                else
                    results[atom] = count == 0 ? 1 : count;
            }

            return results;
        }
    }
}
