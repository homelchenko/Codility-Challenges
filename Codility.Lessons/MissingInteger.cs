using System;

namespace Codility.Lessons
{
    public class MissingInteger
    {
        public int FindMissingNumber(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            return 1;
        }
    }
}
