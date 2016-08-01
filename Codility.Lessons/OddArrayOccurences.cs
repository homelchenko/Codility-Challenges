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

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum ^= array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == sum)
                    return sum;
            }

            throw new ArgumentException();
        }
    }
}
