using Xunit;

namespace Training.LeetCode.PowerOfFour
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/power-of-four/description/
    /// 
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// Example 1:
        /// Input: n = 16
        /// Output: true
        /// Explanation: 4^2 = 16
        /// <br/>
        /// 
        /// Example 2:
        /// Input: n = 1
        /// Output: true
        /// Explanation: 4^0 = 1
        /// 
        /// <br/>
        /// 
        /// Example 3:
        /// Input: n = 5
        /// Output: false
        /// 
        /// <br/>
        /// 
        /// Status: "Accepted"
        /// 
        /// </summary>
        public bool IsPowerOfFour(int n)
        {
            if (n <= 0 ) return false;
            
            while (n % 4 == 0)
            {
                n /= 4;
            }

            return n == 1;
        }
    }


    public class SolutionTests
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(16, true)]
        [InlineData(5, false)]
        public void IsPowerOfFour_ShouldReturnExpectedResult(int n, bool IsPowerOfTwo)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsPowerOfFour(n);

            // Assert
            Assert.Equal(IsPowerOfTwo, result);
        }
    }
}
