using System;

namespace Codility.Lessons
{
    public class CyclicRotation
    {
        public int[] Solution(int[] A, int shift)
        {
            if (shift < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (A.Length == 1)
                return new int[] { A[0] };

            return new int[0];
        }
    }
}
