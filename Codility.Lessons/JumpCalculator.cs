using System;

namespace Codility.Lessons
{
    public class JumpCalculator
    {
        public int CalculateJumps(int origin, int destination, int jumpLength)
        {
            if ((origin < 1) || (destination < 1) || (jumpLength < 1))
            {
                throw new ArgumentException();
            }

            if (origin > destination)
            {
                throw new ArgumentException();
            }

            int distance = destination - origin;

            int jumpNumberBeforeDestination = distance / jumpLength;

            if (distance % jumpLength > 0)
                return jumpNumberBeforeDestination + 1;

            return jumpNumberBeforeDestination;
        }
    }
}
