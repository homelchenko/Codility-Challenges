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

            if (schedule[0] > gapSize)
            {
                throw new ArgumentException();
            }

            if (schedule[0] < gapSize)
            {
                return -1;
            }

            return 0;
        }
    }
}
