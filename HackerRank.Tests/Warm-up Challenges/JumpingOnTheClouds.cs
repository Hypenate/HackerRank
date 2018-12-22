using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerRank.Tests.Warm_up_Challenges
{
    public class JumpingOnTheClouds
    {
        [Fact]
        public void Result_TwoSafeCloudsOneThunder_TwoJumps()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.JumpingOnTheClouds jumpingOnTheClouds = new HackerRank.Warm_up_Challenges.JumpingOnTheClouds();
            int[] clouds = new int[] { 0, 1, 0 };

            //Act
            int jumps = jumpingOnTheClouds.Result(clouds);

            //Assert
            Assert.Equal(2, jumps);
        }

        [Fact]
        public void Result_ThreeSafeCloudsOneThunder_TwoJumps()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.JumpingOnTheClouds jumpingOnTheClouds = new HackerRank.Warm_up_Challenges.JumpingOnTheClouds();
            int[] clouds = new int[] { 0, 1, 0, 0 };

            //Act
            int jumps = jumpingOnTheClouds.Result(clouds);

            //Assert
            Assert.Equal(3, jumps);
        }

        [Fact]
        public void Result_FourSafeCloudsOneThunder_TwoJumps()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.JumpingOnTheClouds jumpingOnTheClouds = new HackerRank.Warm_up_Challenges.JumpingOnTheClouds();
            int[] clouds = new int[] { 0, 0, 1, 0, 0 };

            //Act
            int jumps = jumpingOnTheClouds.Result(clouds);

            //Assert
            Assert.Equal(3, jumps);
        }

        [Fact]
        public void Result_TestSample0()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.JumpingOnTheClouds jumpingOnTheClouds = new HackerRank.Warm_up_Challenges.JumpingOnTheClouds();
            int[] clouds = new int[] { 0, 0, 1, 0, 0, 1, 0 };

            //Act
            int jumps = jumpingOnTheClouds.Result(clouds);

            //Assert
            Assert.Equal(4, jumps);
        }

        [Fact]
        public void Result_TestSample1()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.JumpingOnTheClouds jumpingOnTheClouds = new HackerRank.Warm_up_Challenges.JumpingOnTheClouds();
            int[] clouds = new int[] { 0, 0, 0, 0, 1, 0 };

            //Act
            int jumps = jumpingOnTheClouds.Result(clouds);

            //Assert
            Assert.Equal(3, jumps);
        }
    }
}
