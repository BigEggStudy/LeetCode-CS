//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 31.1 MB
// Link: https://leetcode.com/submissions/detail/401570259/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0399_EvaluateDivision
    {
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            var uf = new UnionFind();

            for (int i = 0; i < equations.Count; i++)
                uf.Union(equations[i][0], equations[i][1], values[i]);

            var result = new double[queries.Count];
            for (int i = 0; i < queries.Count; i++)
            {
                var x = queries[i][0];
                var y = queries[i][1];
                if (uf.Exist(x) && uf.Exist(y))
                {
                    var px = uf.Find(x);
                    var py = uf.Find(y);

                    if (px.ParentIndex == py.ParentIndex)
                    {
                        result[i] = px.Value / py.Value;
                        continue;
                    }
                }

                result[i] = -1;
            }

            return result;
        }

        public class UnionFind
        {
            private IDictionary<string, Node> parents = new Dictionary<string, Node>();

            public Node Find(string index)
            {
                if (!parents.ContainsKey(index))
                    parents.Add(index, new Node(index, 1.0));
                else if (parents[index].ParentIndex != index)
                {
                    var value = parents[index].Value;
                    var parent = Find(parents[index].ParentIndex);
                    parents[index] = new Node(parent.ParentIndex, value * parent.Value);
                }

                return parents[index];
            }

            public bool Exist(string index)
            {
                return parents.ContainsKey(index);
            }

            public void Union(string index1, string index2, double value)
            {
                var pIndex1 = Find(index1);
                var pIndex2 = Find(index2);

                if (pIndex1.ParentIndex != pIndex2.ParentIndex)
                    parents[pIndex1.ParentIndex] = new Node(pIndex2.ParentIndex, value * pIndex2.Value / pIndex1.Value);
            }
        }

        public class Node
        {
            public Node(string parentIndex, double value)
            {
                ParentIndex = parentIndex;
                Value = value;
            }

            public string ParentIndex { get; set; }

            public double Value { get; set; }
        }
    }
}
