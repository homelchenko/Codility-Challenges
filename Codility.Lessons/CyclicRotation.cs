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

            if (A.Length == 1)
                return new int[] { A[0] };

            if (shift == 0)
            {
                int[] rotated = new int[A.Length];
                Array.Copy(A, rotated, A.Length);
                return rotated;
            }

            return new int[0];
        }
    }
}
