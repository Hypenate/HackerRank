using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.StringManipulation
{
  public class AlternatingCharacters
  {
    public int Result(string s)
    {
      char[] chars = s.ToCharArray();
      var deletions = 0;

      for (int i = 1; i < chars.Length; i++)
      {
        if (chars[i] == chars[i - 1]) deletions++;
      }
      
      return deletions;
    }
  }
}
