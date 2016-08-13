using System;

namespace Codility.Lessons
{
    public class MissingElementFinder
    {
        private const int MaxArrayLength = 100001;

        public int FindMissingElement(int[] array)
        {
            if (array.Length == 0 || array.Length > MaxArrayLength)
            {
                throw new ArgumentException();
            }

            return 3 - array[0];
        }
    }
}
