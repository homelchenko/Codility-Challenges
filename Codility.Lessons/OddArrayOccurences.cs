using System;

namespace Codility.Lessons
{
    public class OddArrayOccurences
    {
        public int solution(int[] A)
        {
            return FindUnpaired(A);
        }

        public int FindUnpaired(int[] array)
        {
            if (array.Length % 2 == 0)
            {
                throw new ArgumentException();
            }

            return Int32.MinValue;
        }
    }
}
