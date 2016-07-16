using System;
using System.Collections.Generic;

namespace Codility.Lessons
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            int gapLength = 0;
            int maxGapLength = gapLength;
            bool isInRange = false;

            foreach (byte bit in ConvertToBinary(N))
            {
                if (bit == 0)
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
            }

            return maxGapLength;
        }

        private IEnumerable<byte> ConvertToBinary(int value)
        {
            int remainder = value;

            while (remainder > 0)
            {
                yield return (byte)(remainder % 2);
                remainder /= 2;
            }
        }
    }
}
