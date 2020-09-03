//-----------------------------------------------------------------------------
// Runtime: 120ms
// Memory Usage: 31.6 MB
// Link: https://leetcode.com/submissions/detail/363007096/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _1286_IteratorForCombination
    {
        private readonly int[] nums;
        private readonly string str;
        private readonly int n;
        private readonly int k;
        private bool hasNext;

        public _1286_IteratorForCombination(string characters, int combinationLength)
        {
            str = characters;
            n = characters.Length;
            k = combinationLength;

            hasNext = true;
            nums = new int[k];
            for (int i = 0; i < k; i++)
                nums[i] = i;
        }

        public string Next()
        {
            var sb = new StringBuilder();
            foreach (var index in nums)
                sb.Append(str[index]);

            var j = k - 1;
            while (j >= 0 && nums[j] == n - k + j)
                j--;

            if (j >= 0)
            {
                nums[j]++;
                for (int i = j; i < k; i++)
                    nums[i] = nums[j] + i - j;
            }
            else
                hasNext = false;

            return sb.ToString();
        }

        public bool HasNext()
        {
            return hasNext;
        }
    }

    /**
     * Your CombinationIterator object will be instantiated and called as such:
     * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
     * string param_1 = obj.Next();
     * bool param_2 = obj.HasNext();
     */
}
