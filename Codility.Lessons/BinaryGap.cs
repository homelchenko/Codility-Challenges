namespace Codility.Lessons
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            return 0;
        }

        public string ConvertToBinary(int N)
        {
            int @base = 2;
            int remainder = N;

            string binary = string.Empty;
            while (remainder > 0)
            {
                int modulus = remainder % @base;

                binary += modulus;

                remainder /= @base;
            }

            return binary;
        }
    }
}
