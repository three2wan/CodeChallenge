using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            Console.WriteLine("No of ways of climb stair: " + solution(N));
        }

        public static int solution(int N) 
        {
            /*
            // This is very slow because doig repeated computations/recursion. 
            if (N <= 1)
                return 1;

            return (solution(N-1) + solution(N-2));
            */

            if (N <= 3)
                return N;

            int a = 1;
            int b = 2;

            for (int i = 3; i <= N; i++)
            {
                b += a;
                a = b - a;
            }

            return b;            
        }
    }
}
