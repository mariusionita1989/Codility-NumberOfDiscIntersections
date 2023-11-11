using Codility_NumberOfDiscIntersections;

namespace Codility_NumberOfDiscIntersectionsTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExampleCase()
        {
            Solution solution = new Solution();
            int[] A = { 1, 5, 2, 1, 4, 0 };
            int result = solution.solution(A);
            Assert.Equal(11, result);
        }

        [Fact]
        public void TestEmptyArray()
        {
            Solution solution = new Solution();
            int[] A = { };
            int result = solution.solution(A);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestArrayWithOneElement()
        {
            Solution solution = new Solution();
            int[] A = { 3 };
            int result = solution.solution(A);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestThresholdExceeded()
        {
            Solution solution = new Solution();
            int[] A = new int[Solution.THRESHOLD + 1];
            Array.Fill(A, 1);
            int result = solution.solution(A);
            Assert.Equal(-2, result);
        }

        [Fact]
        public void TestInvalidInputOutOfRange()
        {
            Solution solution = new Solution();
            int[] A = new int[Solution.RANGE_HIGHEST_VALUE + 1];
            int result = solution.solution(A);
            Assert.Equal(-2, result);
        }
    }
}