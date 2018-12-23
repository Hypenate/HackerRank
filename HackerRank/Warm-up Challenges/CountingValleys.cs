using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Warm_up_Challenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/counting-valleys
    /// </summary>
    public class CountingValleys
    {
        public int Result(int n, string s)
        {
            int currentLevel = 0;
            int valleys = 0;
            HikerState hikerState;

            foreach (var hill in s.ToUpper())
            {
                if (hill == 'D')
                {
                    hikerState = HikerState.Down;
                }
                else
                {
                    hikerState = HikerState.Up;
                }

                currentLevel = UpdateLevel(hill, currentLevel);

                if (currentLevel == -1 && hikerState == HikerState.Down)
                {
                    valleys++;
                }
            }

            return valleys;
        }

        private int UpdateLevel(char hill, int currentLevel)
        {
            int newLevel = currentLevel;

            if (hill == 'D')
            {
                newLevel = --currentLevel;
            }
            else
            {
                newLevel = ++currentLevel;
            }

            return newLevel;
        }

        private enum HikerState
        {
            Up,
            Down
        }
    }
}
