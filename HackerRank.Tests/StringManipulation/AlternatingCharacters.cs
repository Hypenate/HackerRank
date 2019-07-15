using Xunit;

namespace HackerRank.Tests.StringManipulation
{
  public class AlternatingCharacters
  {
    [Theory]
    [InlineData("AAAA", 3)]
    [InlineData("BBBBB", 4)]
    [InlineData("ABABABAB", 0)]
    [InlineData("BABABA", 0)]
    [InlineData("AAABBB", 4)]
    public void Result_SampleInput(string providedSample, int providedResult)
    {
      //Arrange
      HackerRank.StringManipulation.AlternatingCharacters alternatingCharacters = new HackerRank.StringManipulation.AlternatingCharacters();

      //Act
      int result = alternatingCharacters.Result(providedSample);

      //Assert
      Assert.Equal(providedResult, result);
    }

    [Theory]
    [InlineData("AAABBBAABB", 6)]
    [InlineData("AABBAABB", 4)]
    [InlineData("ABABABAA", 1)]
    public void Result_TestSample1(string providedSample, int providedResult)
    {
      //Arrange
      HackerRank.StringManipulation.AlternatingCharacters alternatingCharacters = new HackerRank.StringManipulation.AlternatingCharacters();

      //Act
      int result = alternatingCharacters.Result(providedSample);

      //Assert
      Assert.Equal(providedResult, result);
    }

    [Theory]
    [InlineData("ABBABBAA", 3)]
    public void Result_TestSample2(string providedSample, int providedResult)
    {
      //Arrange
      HackerRank.StringManipulation.AlternatingCharacters alternatingCharacters = new HackerRank.StringManipulation.AlternatingCharacters();

      //Act
      int result = alternatingCharacters.Result(providedSample);

      //Assert
      Assert.Equal(providedResult, result);
    }
  }
}
