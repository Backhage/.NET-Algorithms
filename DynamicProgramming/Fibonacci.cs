using System.Numerics;

namespace DynamicProgramming
{
    public class Fibonacci
    {
        public static BigInteger Calculate(int n)
        {
            if (n < 1 || n > 2000)
            {
                return new BigInteger(-1);
            }

            var prev2 = new BigInteger(0);
            var prev1 = new BigInteger(1);
            var result = prev2 + prev1;

            for (int i = 2; i < n; i++)
            {
                prev2 = prev1;
                prev1 = result;
                result = prev2 + prev1;
            }

            return result;
        }
    }
}
