using System;

namespace Codility.Lessons
{
    public class FrogRiverNavigator
    {
        public const int MaxAllowedGapSize = 100000;

        public const int MaxAllowedScheduleLength = 100000;

        public int CalculateTimeToOtherBank(int gapSize, int[] schedule)
        {
            if (gapSize <= 0 || gapSize > MaxAllowedGapSize)
            {
                throw new ArgumentException();
            }

            if (schedule.Length == 0 || schedule.Length > MaxAllowedScheduleLength)
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
