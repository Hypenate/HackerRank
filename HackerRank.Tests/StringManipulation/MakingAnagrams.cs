using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerRank.Tests.StringManipulation
{
  public class MakingAnagrams
  {
    [Fact]
    public void Result_SameInput()
    {
      //Arrange
      HackerRank.StringManipulation.MakingAnagrams makingAnagrams = new HackerRank.StringManipulation.MakingAnagrams();
      string a = "lepel";
      string b = "lepel";

      //Act
      int result = makingAnagrams.Result(a, b);

      //Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void Result_DifferentInput()
    {
      //Arrange
      HackerRank.StringManipulation.MakingAnagrams makingAnagrams = new HackerRank.StringManipulation.MakingAnagrams();
      string a = "abc";
      string b = "def";

      //Act
      int result = makingAnagrams.Result(a, b);

      //Assert
      Assert.Equal(6, result);
    }

    [Fact]
    public void Result_Es()
    {
      //Arrange
      HackerRank.StringManipulation.MakingAnagrams makingAnagrams = new HackerRank.StringManipulation.MakingAnagrams();
      string a = "ee";
      string b = "e";

      //Act
      int result = makingAnagrams.Result(a, b);

      //Assert
      Assert.Equal(1, result);
    }

    [Fact]
    public void Result_TwoExtraEs()
    {
      //Arrange
      HackerRank.StringManipulation.MakingAnagrams makingAnagrams = new HackerRank.StringManipulation.MakingAnagrams();
      string a = "leepeel";
      string b = "lepel";

      //Act
      int result = makingAnagrams.Result(a, b);

      //Assert
      Assert.Equal(2, result);
    }

    [Fact]
    public void Result_TestSample0()
    {
      //Arrange
      HackerRank.StringManipulation.MakingAnagrams makingAnagrams = new HackerRank.StringManipulation.MakingAnagrams();
      string a = "cde";
      string b = "abc";

      //Act
      int result = makingAnagrams.Result(a, b);

      //Assert
      Assert.Equal(4, result);
    }

    [Fact]
    public void Result_TestSample1()
    {
      //Arrange
      HackerRank.StringManipulation.MakingAnagrams makingAnagrams = new HackerRank.StringManipulation.MakingAnagrams();
      string a = "fcrxzwscanmligyxyvym";
      string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";

      //Act
      int result = makingAnagrams.Result(a, b);

      //Assert
      Assert.Equal(30, result);
    }

    [Fact]
    public void Result_TestSample2()
    {
      //Arrange
      HackerRank.StringManipulation.MakingAnagrams makingAnagrams = new HackerRank.StringManipulation.MakingAnagrams();
      string a = "showman";
      string b = "woman";

      //Act
      int result = makingAnagrams.Result(a, b);

      //Assert
      Assert.Equal(2, result);
    }
  }
}
