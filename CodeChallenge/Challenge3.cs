using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {1, -3, 6, 40, 1, 2};
            Console.WriteLine("Min value in array: " + solution(A));
        }

        public static int solution(int[] A) 
        {
            int minValue = 1;

            Array.Sort(A);
            foreach(int i in A)
            {
                if (minValue == i)
                    minValue++;
            }

            return minValue;
        }
    }
}
