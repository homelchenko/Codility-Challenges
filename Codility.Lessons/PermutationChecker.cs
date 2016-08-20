using System;

namespace Codility.Lessons
{
    public class PermutationChecker
    {
        private const int MaxArrayLength = 100000;

        public bool IsPermutation(int[] array)
        {
            if (array.Length == 0 || array.Length > MaxArrayLength)
            {
                throw new ArgumentException();
            }

            return array[0] == 1;
        }
    }
}
