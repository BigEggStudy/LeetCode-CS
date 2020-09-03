//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 23 MB
// Link: https://leetcode.com/submissions/detail/260405571/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0273_IntegerToEnglishWords
    {
        public string NumberToWords(int num)
        {
            if (num == 0) return "Zero";

            int billion = num / 1000000000;
            int million = (num - billion * 1000000000) / 1000000;
            int thousand = (num - billion * 1000000000 - million * 1000000) / 1000;
            int rest = num - billion * 1000000000 - million * 1000000 - thousand * 1000;

            string result = "";
            if (billion != 0) result = ThreeDigitsToString(billion) + " Billion";
            if (million != 0)
            {
                if (!string.IsNullOrEmpty(result)) result += " ";
                result += ThreeDigitsToString(million) + " Million";
            }
            if (thousand != 0)
            {
                if (!string.IsNullOrEmpty(result)) result += " ";
                result += ThreeDigitsToString(thousand) + " Thousand";
            }
            if (rest != 0)
            {
                if (!string.IsNullOrEmpty(result)) result += " ";
                result += ThreeDigitsToString(rest);
            }
            return result;
        }


        private string OneDigitToString(int num)
        {
            switch (num)
            {
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
            }
            return "";
        }

        private string TwoDigitsLessThan20ToString(int num)
        {
            switch (num)
            {
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
            }
            return "";
        }

        private string TenMultipleToString(int num)
        {
            switch (num)
            {
                case 2: return "Twenty";
                case 3: return "Thirty";
                case 4: return "Forty";
                case 5: return "Fifty";
                case 6: return "Sixty";
                case 7: return "Seventy";
                case 8: return "Eighty";
                case 9: return "Ninety";
            }
            return "";
        }

        private string TwoDigitsToString(int num)
        {
            if (num == 0)
                return "";
            else if (num < 10)
                return OneDigitToString(num);
            else if (num < 20)
                return TwoDigitsLessThan20ToString(num);
            else
            {
                int tenner = num / 10;
                int rest = num - tenner * 10;
                if (rest != 0)
                    return TenMultipleToString(tenner) + " " + OneDigitToString(rest);
                else
                    return TenMultipleToString(tenner);
            }
        }

        private string ThreeDigitsToString(int num)
        {
            int hundred = num / 100;
            int rest = num - hundred * 100;
            string res = "";
            if (hundred * rest != 0)
                res = OneDigitToString(hundred) + " Hundred " + TwoDigitsToString(rest);
            else if ((hundred == 0) && (rest != 0))
                res = TwoDigitsToString(rest);
            else if ((hundred != 0) && (rest == 0))
                res = OneDigitToString(hundred) + " Hundred";
            return res;
        }
    }
}
