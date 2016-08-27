namespace Codility.Lessons.Test
{
    public static class ArrayUtilities
    {
        public static void SeedWithSeries(this int[] array, int firstValue)
        {
            int seed = firstValue - 1;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ++seed;
            }
        }

        public static void SeedWith(this int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }
    }
}
