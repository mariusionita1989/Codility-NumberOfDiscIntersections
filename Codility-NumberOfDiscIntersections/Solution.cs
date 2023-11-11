using System.Runtime.CompilerServices;

namespace Codility_NumberOfDiscIntersections
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 0;
        public const int RANGE_HIGHEST_VALUE = 100000;
        public const int THRESHOLD = 10000000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE)
            {
                long[] leftEdges = new long[N];
                long[] rightEdges = new long[N];
                for (int i = 0; i < N; i++)
                {
                    leftEdges[i] = (long)i - (long)A[i]; // Updated this line
                    rightEdges[i] = (long)i + (long)A[i]; // Updated this line
                }

                Array.Sort(leftEdges);
                Array.Sort(rightEdges);
                int intersections = 0;
                int activeIntersections = 0;
                int leftIndex = 0;

                for (int rightIndex = 0; rightIndex < N; rightIndex++)
                {
                    while (leftIndex < N && leftEdges[leftIndex] <= rightEdges[rightIndex])
                    {
                        activeIntersections++;
                        leftIndex++;
                    }

                    activeIntersections--;
                    intersections += activeIntersections;

                    if (intersections > THRESHOLD)
                        return -1;
                }

                return intersections >= 0 ? intersections : 0;
            }

            return -2;
        }
    }
}
