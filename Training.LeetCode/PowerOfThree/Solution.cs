using Xunit;

namespace Training.LeetCode.PowerOfThree
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/power-of-three/description/
    /// 
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// Example 1:
        /// Input: n = 27
        /// Output: true
        /// Explanation: 3^3 = 27
        /// <br/>
        /// 
        /// Example 2:
        /// Input: n = -1
        /// Output: false
        /// 
        /// <br/>
        /// 
        /// Example 3:
        /// Input: n = 0
        /// Output: false
        /// 
        /// <br/>
        /// 
        /// Status: "Accepted"
        /// 
        /// </summary>
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0 ) return false;
            
            while (n % 3 == 0)
            {
                n /= 3;
            }

            return n == 1;
        }
    }


    public class SolutionTests
    {
        [Theory]
        [InlineData(0, false)]
        [InlineData(27, true)]
        [InlineData(-1, false)]
        public void IsPowerOfThree_ShouldReturnExpectedResult(int n, bool IsPowerOfTwo)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsPowerOfThree(n);

            // Assert
            Assert.Equal(IsPowerOfTwo, result);
        }
    }
}
