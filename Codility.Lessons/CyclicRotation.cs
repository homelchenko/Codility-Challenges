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

            if (A.Length == 0)
                return new int[0];

            if (A.Length == 1)
                return new int[] { A[0] };

            if (shift == 0)
            {
                int[] rotated = new int[A.Length];
                Array.Copy(A, rotated, A.Length);
                return rotated;
            }

            int tempSpace = A[A.Length - 1];
            for (int i = A.Length - 1; i > 0; i--)
            {
                A[i] = A[i - 1];
            }

            A[0] = tempSpace;

            return A;
        }
    }
}
