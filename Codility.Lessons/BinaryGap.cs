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
            for (int i = 1; i < binaryInput.Length; i++) // 1st element is to be '1' anyways
            {
                if (binaryInput[i] == '0')
                    gapLength++;
                else
                {
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
