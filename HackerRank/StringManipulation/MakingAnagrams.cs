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
      var aLetters = a.ToCharArray().OrderBy((l) => l).ToList();
      var bLetters = b.ToCharArray().OrderBy((l) => l).ToList();

      dropCount = ClearDifferenceInOccurances(aLetters, bLetters);

      return dropCount;
    }

    public int ClearDifferenceInOccurances(List<char> a, List<char> b)
    {
      int dropCount = 0;

      List<char> allLeters = new List<char>();
      allLeters.AddRange(a);
      allLeters.AddRange(b);

      foreach (var letter in allLeters.Distinct())
      {
        var countA = a.Count(l => letter == l);
        var countB = b.Count(l => letter == l);

        // Check for duplicates or differences
        if (countA != countB)
        {
          if (countA > countB)
          {
            for (int i = 0; i < (countA - countB); i++)
            {
              a.Remove(letter);
              dropCount++;
            }
          }
          else
          {
            for (int i = 0; i < (countB - countA); i++)
            {
              b.Remove(letter);
              dropCount++;
            }
          }
        }
      }

      return dropCount;
    }
  }
}
