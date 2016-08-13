using System;

namespace Codility.Lessons
{
    public class MissingElementFinder
    {
        public const int MaxArrayLength = 100000;

        public int FindMissingElement(int[] array)
        {
            if (array.Length > MaxArrayLength)
            {
                throw new ArgumentException();
            }

            checked
            {
                long maxPossibleArrayValue = array.Length + 1;
                long maxPossibleSum = (1 + maxPossibleArrayValue) * maxPossibleArrayValue / 2;

                long actualSum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    actualSum += array[i];
                }

                return (int)(maxPossibleSum - actualSum);
            }
        }
    }
}
