using System;

namespace Codility.Lessons
{
    public class JumpCalculator
    {
        public int CalculateJumps(int origin, int destination, int jumpLength)
        {
            if (origin < destination)
            {
                throw new ArgumentException();
            }

            return Int32.MinValue;
        }
    }
}
