using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerRank.Tests.Warm_up_Challenges
{
    public class SockMerchant
    {
        [Fact]
        public void SockMerchant_OnePair_ReturnOne()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.SockMerchant sockMerchant = new HackerRank.Warm_up_Challenges.SockMerchant();
            List<int> socks = new List<int>()
            {
                1, 1
            };

            //Act
            int result = sockMerchant.Result(socks.Count, socks.ToArray());

            //Assert
            Assert.True(result == 1);
        }

        [Fact]
        public void SockMerchant_TwoPair_ReturnTwo()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.SockMerchant sockMerchant = new HackerRank.Warm_up_Challenges.SockMerchant();
            List<int> socks = new List<int>()
            {
                1, 2, 1, 2
            };

            //Act
            int result = sockMerchant.Result(socks.Count, socks.ToArray());

            //Assert
            Assert.True(result == 2);
        }


        [Fact]
        public void SockMerchant_Unequal_ReturnTwoPair()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.SockMerchant sockMerchant = new HackerRank.Warm_up_Challenges.SockMerchant();
            List<int> socks = new List<int>()
            {
                1, 2, 1, 2, 3
            };

            //Act
            int result = sockMerchant.Result(socks.Count, socks.ToArray());

            //Assert
            Assert.True(result == 2);
        }

        [Fact]
        public void SockMerchant_TestSample0()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.SockMerchant sockMerchant = new HackerRank.Warm_up_Challenges.SockMerchant();
            List<int> socks = new List<int>()
            {
                10, 20, 20, 10, 10, 30, 50, 10, 20
            };

            //Act
            int result = sockMerchant.Result(socks.Count, socks.ToArray());

            //Assert
            Assert.True(result == 3);
        }

        [Fact]
        public void SockMerchant_TestSample1()
        {
            //Arrange
            HackerRank.Warm_up_Challenges.SockMerchant sockMerchant = new HackerRank.Warm_up_Challenges.SockMerchant();
            List<int> socks = new List<int>()
            {
                1, 1 ,3 ,1 ,2, 1, 3, 3, 3, 3
            };

            //Act
            int result = sockMerchant.Result(socks.Count, socks.ToArray());

            //Assert
            Assert.True(result == 4);
        }
    }
}
