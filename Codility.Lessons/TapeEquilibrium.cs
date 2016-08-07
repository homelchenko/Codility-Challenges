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

            int[] differences = new int[array.Length - 1];

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                rightSum += array[i];
            }

            for (int i = 1; i < array.Length; i++)
            {
                leftSum += array[i - 1];
                rightSum -= array[i - 1];

                differences[i - 1] = Math.Abs(leftSum - rightSum);
            }

            int equilibrium = differences[0];
            for (int i = 1; i < differences.Length; i++)
            {
                if (equilibrium > differences[i])
                    equilibrium = differences[i];
            }

            return equilibrium;
        }
    }
}
