using System;

namespace Codility.Lessons
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            if (N == 0)
                return 0;

            int gapLength = 0;
            int maxGapLength = gapLength;
            bool isInRange = false;

            int remainder = N;

            while (remainder > 0)
            {
                int modulus = remainder % 2;

                if (modulus == 0)
                {
                    if (isInRange)
                    {
                        gapLength++;
                    }
                }
                else
                {
                    isInRange = true;
                    maxGapLength = Math.Max(maxGapLength, gapLength);
                    gapLength = 0;
                }

                remainder /= 2;
            }

            return maxGapLength;
        }
    }
}
