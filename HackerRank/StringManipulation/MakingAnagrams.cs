using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HackerRank.StringManipulation
{
  public class MakingAnagrams
  {
    public int Result(string a, string b)
    {
      int dropCount;

      dropCount = ClearDifferenceInOccurances(a.ToCharArray(), b.ToCharArray());

      return dropCount;
    }

    public int ClearDifferenceInOccurances(char[] a, char[] b)
    {
      int dropCount = 0;

      List<char> allLeters = new List<char>();
      allLeters.AddRange(a);
      allLeters.AddRange(b);

      foreach (var letter in allLeters.Distinct())
      {
        var countA = a.Count(l => letter == l);
        var countB = b.Count(l => letter == l);

        // Check for differences
        if (countA != countB)
        {
          dropCount += (countA > countB)
            ? (countA - countB)
            : (countB - countA);
        }
      }

      return dropCount;
    }
  }
}
