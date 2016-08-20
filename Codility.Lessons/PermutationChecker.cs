using System;

namespace Codility.Lessons
{
    public class PermutationChecker
    {
        private const int MaxArrayLength = 100000;
        private const int MinValue = 1;

        public bool IsPermutation(int[] array)
        {
            if (array.Length == 0 || array.Length > MaxArrayLength)
            {
                throw new ArgumentException();
            }

            bool[] flags = new bool[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                int candidateValue = array[i];

                ValidateValue(candidateValue);

                if (candidateValue > array.Length)
                {
                    // Value falls beyond permutation limits
                    return false;
                }

                bool currentFlag = flags[candidateValue];
                if (currentFlag)
                {
                    // Value is found more than once
                    return false;
                }

                flags[candidateValue] = true;
            }

            for (int i = 1; i < flags.Length; i++)
            {
                if (!flags[i])
                {
                    // Value to be full permutation is missing
                    return false;
                }
            }

            return true;
        }

        private static void ValidateValue(int value)
        {
            if (value < MinValue)
            {
                throw new ArgumentException();
            }
        }
    }
}
