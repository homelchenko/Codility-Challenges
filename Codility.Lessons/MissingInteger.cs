using System;

namespace Codility.Lessons
{
    public class MissingInteger
    {
        private const int MaxArrayLength = 100000;

        public int FindMissingNumber(int[] array)
        {
            if (array.Length == 0 || array.Length > MaxArrayLength)
            {
                throw new ArgumentException();
            }

            int maxPossibleValue = array.Length + 1;

            // We got +1 here because zero ('0') is not acceptable value
            int[] counts = new int[maxPossibleValue + 1];

            for(int i = 0; i < array.Length; i++)
            {
                int itemValue = array[i];

                if (itemValue > maxPossibleValue)
                {
                    continue;
                }

                counts[itemValue]++;
            }

            for (int i = 1; i < counts.Length; i++)
            {
                if (counts[i] == 0)
                {
                    return i;
                }
            }

            // We must not ever reach this point
            throw new Exception();
        }
    }
}
