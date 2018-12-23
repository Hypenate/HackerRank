using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerRank.Tests.Warm_up_Challenges
{
    public class RepeatedString
    {
        [Fact]
        public void Result_OneCharToTen_TenA()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.RepeatedString repeatedString = new HackerRank.Warm_up_Challenges.RepeatedString();

            //Act
            long result = repeatedString.Result("a", 10);

            //Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Result_TwoCharToTen_FiveA()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.RepeatedString repeatedString = new HackerRank.Warm_up_Challenges.RepeatedString();

            //Act
            long result = repeatedString.Result("ab", 10);

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Result_SixCharToTwo_OneA()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.RepeatedString repeatedString = new HackerRank.Warm_up_Challenges.RepeatedString();

            //Act
            long result = repeatedString.Result("abcdef", 2);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Result_SixCharToTwo_ZeroA()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.RepeatedString repeatedString = new HackerRank.Warm_up_Challenges.RepeatedString();

            //Act
            long result = repeatedString.Result("bcdefa", 2);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Result_SixToZero_OneA()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.RepeatedString repeatedString = new HackerRank.Warm_up_Challenges.RepeatedString();

            //Act
            long result = repeatedString.Result("abcdef", 0);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Result_ThreeCharToTen_OneA()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.RepeatedString repeatedString = new HackerRank.Warm_up_Challenges.RepeatedString();

            //Act
            long result = repeatedString.Result("aab", 10);

            //Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Result_ZeroCharToTen_OneA()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.RepeatedString repeatedString = new HackerRank.Warm_up_Challenges.RepeatedString();

            //Act
            long result = repeatedString.Result("", 10);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Result_StressTest()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.RepeatedString repeatedString = new HackerRank.Warm_up_Challenges.RepeatedString();

            //Act
            long result = repeatedString.Result("3N4UniiuXLtoMXVTOM0LK34mvjTQSQQeS6TRZ5bvOb8Wnaq8oJL5wo5NUbDVaa5todv8iBTd4cepF7gyKXrqJlbiLKLdkT7iqJ9Y", 10000000000000);

            //Assert
            Assert.True(result > 0);
        }

        [Fact]
        public void Result_TestSample0()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.RepeatedString repeatedString = new HackerRank.Warm_up_Challenges.RepeatedString();

            //Act
            long result = repeatedString.Result("aba", 10);

            //Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void ResultTestSample1()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.RepeatedString repeatedString = new HackerRank.Warm_up_Challenges.RepeatedString();

            //Act
            long result = repeatedString.Result("a", 1000000000000);

            //Assert
            Assert.Equal(1000000000000, result);
        }
    }
}
