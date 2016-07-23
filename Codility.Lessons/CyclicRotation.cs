using System;

namespace Codility.Lessons
{
    public class CyclicRotation
    {
        public int[] Solution(int[] A, int shift)
        {
            if (shift < 0 || shift > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (A.Length == 0 || A.Length == 1)
            {
                return A;
            }

            int minimalShift = shift % A.Length;

            if (minimalShift == 0)
            {
                return A;
            }

            int[] olderItemsArray = new int[minimalShift];
            for (int k = 0; k < minimalShift; k++)
            {
                olderItemsArray[k] = A[A.Length - minimalShift + k];
            }

            int remainingLength = A.Length - minimalShift;
            for (int i = remainingLength - 1; i >= 0; i--)
            {
                A[i + minimalShift] = A[i];
            }

            for (int k = 0; k < minimalShift; k++)
            {
                A[k] = olderItemsArray[k];
            }

            return A;
        }
    }
}
