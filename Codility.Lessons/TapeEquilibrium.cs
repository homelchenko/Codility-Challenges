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

            int sequenceSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sequenceSum += array[i];
            }

            int leftSum = 0;
            int rightSum = sequenceSum;
            int equilibriumDifference = Math.Abs(leftSum - rightSum);

            for (int i = 1; i < array.Length; i++)
            {
                leftSum += array[i - 1];
                rightSum -= array[i - 1];

                int difference = Math.Abs(leftSum - rightSum);
                if (equilibriumDifference > difference)
                {
                    equilibriumDifference = difference;
                }
            }

            return equilibriumDifference;
        }
    }
}
