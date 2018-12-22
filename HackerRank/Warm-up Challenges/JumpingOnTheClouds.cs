using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Warm_up_Challenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds
    /// </summary>
    public class JumpingOnTheClouds
    {
        public int Result(int[] clouds)
        {
            int lastCloud = clouds.Length - 1;
            int jumps = 0;

            for (int i = 0; i < lastCloud; i++)
            {
                if (clouds[i] == (int)Cloud.Safe)
                {
                    if (i + 1 != lastCloud && clouds[i + 1] == (int)Cloud.Safe)
                    {
                        i++;
                    }

                    if (i + 2 != lastCloud && clouds[i + 2] == (int)Cloud.Safe)
                    {
                        i++;
                    }
                }

                jumps++;
            }

            return jumps;
        }

        private enum Cloud
        {
            Safe = 0,
            Thunderhead = 1
        }
    }
}
