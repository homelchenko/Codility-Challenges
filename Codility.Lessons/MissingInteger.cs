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

            return 1;
        }
    }
}
