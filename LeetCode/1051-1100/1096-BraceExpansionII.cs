//-----------------------------------------------------------------------------
// Runtime: 308ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1096_BraceExpansionII
    {
        public IList<string> BraceExpansionII(string expression)
        {
            var stack = new Stack<List<string>>();
            var union = new List<string>();
            var product = new List<string>() { "" };

            foreach (var ch in expression)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    for (int i = 0; i < product.Count; i++)
                        product[i] += ch;
                }
                else if (ch == '{')
                {
                    stack.Push(union);
                    stack.Push(product);
                    union = new List<string>();
                    product = new List<string>() { "" };
                }
                else if (ch == '}')
                {
                    var pre_product = stack.Pop();
                    var pre_union = stack.Pop();

                    union.AddRange(product);
                    product = new List<string>();
                    foreach (var str1 in pre_product)
                        foreach (var str2 in union)
                            product.Add(str1 + str2);
                    union = pre_union;
                }
                else
                {
                    union.AddRange(product);
                    product = new List<string>() { "" };
                }
            }

            union.AddRange(product);
            return union.Distinct().OrderBy(s => s).ToList();
        }
    }
}
