using System;

namespace Codility.Lessons
{
    public class MissingInteger
    {
        public const int MaxArrayLength = 100000;

        public int FindMissingNumber(int[] array)
        {
            if (array.Length == 0 || array.Length > MaxArrayLength)
            {
                throw new ArgumentException();
            }

            int maxPossibleValue = array.Length + 1;

            int[] counts = new int[maxPossibleValue];

            for(int i = 0; i < array.Length; i++)
            {
                int itemValue = array[i];
                if (itemValue <= 0 || itemValue > maxPossibleValue)
                {
                    continue;
                }

                counts[itemValue - 1]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == 0)
                {
                    return i + 1;
                }
            }

            // We must not ever reach this point
            throw new Exception();
        }
    }
}
