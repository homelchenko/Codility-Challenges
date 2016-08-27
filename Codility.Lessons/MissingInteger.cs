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

            int[] counts = new int[array.Length + 2];

            for(int i = 0; i < array.Length; i++)
            {
                counts[array[i]]++;
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
