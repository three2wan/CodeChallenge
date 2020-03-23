using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {1, 3, 4, 2, 2};
            Console.WriteLine("Duplicate no: {0}", FindDuplicate(A));
        }

        //By using Floyd's tortoise and hare algorithm where hare move 2x faster than tortoise until they meet at meeting point.
        static int FindDuplicate(int[] A)
        {
            int tortoise = A[0];
            int hare = A[0];

            while (true)
            {
                tortoise = A[tortoise];
                hare = A[A[hare]];
                
                if (tortoise == hare) //Meeting point
                    break;
            }

            int ptr1 = A[0];
            int ptr2 = tortoise;

            while (ptr1 != ptr2)
            {
                ptr1 = A[ptr1];
                ptr2 = A[ptr2];
            }
            
            return ptr1;
        }
    }
}
