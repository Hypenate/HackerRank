using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Warm_up_Challenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/repeated-string
    /// </summary>
    public class RepeatedString
    {
        // Complete the repeatedString function below.
        public long Result(string s, long n)
        {
            #region Checks
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            if (s.Count(b => b == 'a') == s.Length)
            {
                return n;
            }

            if (n == 0)
            {
                return 0;
            }
            #endregion

            long countCharA;

            long remainingChars = n % s.Length;
            long fullDuplicates = n / s.Length;
            countCharA = s.Count(b => b == 'a') * fullDuplicates;
            countCharA += (s.Substring(0, (int)remainingChars)).Count(b => b == 'a');

            return countCharA;
        }
    }
}
