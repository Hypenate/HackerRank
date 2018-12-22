using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerRank.Tests.Warm_up_Challenges
{
    public class CountingValleys
    {
        [Fact]
        public void Result_OneUp_ReturnZero()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.CountingValleys countingValleys = new HackerRank.Warm_up_Challenges.CountingValleys();
            string hills = "U";

            //Act
            int result = countingValleys.Result(hills.Length, hills);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Result_UpAndDown_ReturnZero()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.CountingValleys countingValleys = new HackerRank.Warm_up_Challenges.CountingValleys();
            string hills = "UD";

            //Act
            int result = countingValleys.Result(hills.Length, hills);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Result_DownAndUp_ReturnOne()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.CountingValleys countingValleys = new HackerRank.Warm_up_Challenges.CountingValleys();
            string hills = "DU";

            //Act
            int result = countingValleys.Result(hills.Length, hills);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Result_TestSample0()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.CountingValleys countingValleys = new HackerRank.Warm_up_Challenges.CountingValleys();
            string hills = "UDDDUDUU";

            //Act
            int result = countingValleys.Result(hills.Length, hills);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Result_TestSample1()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.CountingValleys countingValleys = new HackerRank.Warm_up_Challenges.CountingValleys();
            string hills = "DDUUDDUDUUUD";

            //Act
            int result = countingValleys.Result(hills.Length, hills);

            //Assert
            Assert.Equal(2, result);
        }
    }
}
