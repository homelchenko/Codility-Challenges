namespace Codility.Lessons
{
    public class FrogRiverNavigator
    {
        public int CalculateTimeToOtherBank(int gapSize, int[] schedule)
        {
            if (schedule[0] < gapSize)
                return -1;

            return 0;
        }
    }
}
