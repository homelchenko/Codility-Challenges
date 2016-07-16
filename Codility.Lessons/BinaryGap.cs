using System;

namespace Codility.Lessons
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            if (N == 0)
                return 0;

            string binaryInput = ConvertToBinary(N);

            int gapLength = 0;
            int maxGapLength = gapLength;
            bool isInRange = false;

            for (int i = binaryInput.Length - 1; i >= 0; i--)
            {
                if (binaryInput[i] == '0' & isInRange)
                {
                    gapLength++;
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

        public string ConvertToBinary(int N)
        {
            int @base = 2;
            int remainder = N;

            string binary = string.Empty;
            while (remainder > 0)
            {
                int modulus = remainder % @base;

                binary = modulus + binary;

                remainder /= @base;
            }

            return binary;
        }
    }
}
