using System;

namespace Codility.Lessons
{
    public class MissingElement
    {
        public int FindMissingElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            return Int32.MinValue;
        }
    }
}
