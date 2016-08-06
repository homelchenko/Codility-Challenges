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
            if (array.Length == 0 || array.Length == 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            return Int32.MinValue;
        }
    }
}
