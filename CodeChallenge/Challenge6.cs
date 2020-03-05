using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = -210;
            Console.WriteLine("Max value: {0}", Solution(N));
        }

        static int Solution(int N)
        {
            int maxValue = -90000;
            int digit = 5;

            // special case, if N = 0
            if (N == 0)
                return digit * 10;

            // if N is negative value, hold negative value (-1) 
            int negative = N/Math.Abs(N);
            int absN = Math.Abs(N);
            int noOfDigit = 0;

            while (absN > 0)
            {
                noOfDigit++;
                absN /= 10;
            }
            
            int position = 1;
            for (int i = 0; i <= noOfDigit; i++)
            {
                // Formula to insert digit on each position of number
                int newValue = ((Math.Abs(N) / position) * (position * 10)) + (digit * position) + (Math.Abs(N) % position);

                position *= 10;

                if (newValue * negative > maxValue)
                    maxValue = newValue * negative;
            }

            return maxValue;
        }
    }
}
