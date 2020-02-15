using System;
namespace HackerRank
{
    public class MathChallenges
    {
        public static int RecursiveFactorial(int num)
        {
            //n! = n * (n-1)!
            return num == 0 ? 1 : num * RecursiveFactorial(num - 1);
        }

        public static int Fibonacci(int num)
        {
            // Fn = Fn-1 + Fn-2
            return 1;
        }
    }
}
