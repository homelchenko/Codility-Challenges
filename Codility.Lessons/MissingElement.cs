using System;

namespace Codility.Lessons
{
    public class MissingElement
    {
        private const int MaxArrayLength = 100001;

        public int FindMissingElement(int[] array)
        {
            if (array.Length == 0 || array.Length > MaxArrayLength)
            {
                throw new ArgumentException();
            }

            return Int32.MinValue;
        }
    }
}
