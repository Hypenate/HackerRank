using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Warm_up_Challenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/sock-merchant/problem
    /// </summary>
    public class SockMerchant
    {
        public int Result(int n, int[] ar)
        {
            int pairs = 0;

            var socksPerType = ar.GroupBy(b => b).Select(b => new { Sock = b.Key, Count = b.Count() }).ToDictionary(b => b.Sock, b => b.Count);

            foreach (var type in socksPerType)
            {
                if (type.Value % 2 != 0)
                {
                    int value = type.Value;
                    pairs += --value / 2;
                }
                else
                {
                    pairs += type.Value / 2;
                }
            }

            return pairs;
        }
    }
}
