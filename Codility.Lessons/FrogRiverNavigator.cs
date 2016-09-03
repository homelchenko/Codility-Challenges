using System;

namespace Codility.Lessons
{
    public class FrogRiverNavigator
    {
        public int CalculateTimeToOtherBank(int gapSize, int[] schedule)
        {
            if (gapSize <= 0)
            {
                throw new ArgumentException();
            }

            if (schedule.Length == 0)
            {
                throw new ArgumentException();
            }

            bool[] gaps = new bool[gapSize];

            int gapsLeft = gapSize;
            for (int i = 0; i < schedule.Length; i++)
            {
                int coveredPosition = schedule[i];

                if (coveredPosition <= 0 || coveredPosition > gapSize)
                {
                    throw new ArgumentException();
                }

                if (!gaps[coveredPosition - 1])
                {
                    gaps[coveredPosition - 1] = true;
                    gapsLeft--;
                    if (gapsLeft == 0)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
