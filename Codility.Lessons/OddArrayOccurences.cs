using System;

namespace Codility.Lessons
{
    public class OddArrayOccurences
    {
        public const int Duplicate = 0;

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

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum ^= array[i];
            }

            return sum;
        }
    }
}
