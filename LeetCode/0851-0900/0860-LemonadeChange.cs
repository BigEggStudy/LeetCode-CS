//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 28.5 MB
// Link: https://leetcode.com/submissions/detail/344214861/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0860_LemonadeChange
    {
        public bool LemonadeChange(int[] bills)
        {
            int fives = 0, tens = 0;
            foreach (var bill in bills)
            {
                if (bill == 5)
                    fives++;
                else if (bill == 10)
                {
                    if (fives > 0)
                    {
                        fives--;
                        tens++;
                    }
                    else
                        return false;
                }
                else
                {
                    if (fives > 0 && tens > 0)
                    {
                        fives--;
                        tens--;
                    }
                    else if (fives >= 3)
                        fives -= 3;
                    else
                        return false;
                }
            }

            return true;
        }
    }
}
