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

            for (int i = 0; i < schedule.Length; i++)
            {
                int coveredPosition = schedule[i];

                if (coveredPosition > gapSize)
                {
                    throw new ArgumentException();
                }

                gaps[coveredPosition - 1] = true;
            }

            bool isPathReady = true;
            for (int i = 0; i < gaps.Length; i++)
            {
                isPathReady &= gaps[i];
            }

            return isPathReady ? schedule.Length - 1 : -1;
        }
    }
}
