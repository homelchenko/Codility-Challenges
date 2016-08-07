using System;

namespace Codility.Lessons
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            return FindEquilibrium(A);
        }

        public int FindEquilibrium(int[] array)
        {
            if (array.Length <= 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            int leftSum = array[0];
            int rightSum = 0;

            for (int i = 1; i < array.Length; i++)
            {
                rightSum += array[i];
            }

            return Math.Abs(leftSum - rightSum);
        }
    }
}
