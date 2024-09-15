using Xunit;

namespace Training.LeetCode.PowerOfTwo
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/power-of-two/description/
    /// 
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// Example 1:
        /// Input: n = 1
        /// Output: true
        /// Explanation: 2^0 = 1
        /// <br/>
        /// 
        /// Example 2:
        /// Input: n = 16
        /// Output: true
        /// Explanation: 2^4 = 16
        /// 
        /// <br/>
        /// 
        /// Example 3:
        /// Input: n = 3
        /// Output: false
        /// 
        /// <br/>
        /// 
        /// Status: "Accepted"
        /// 
        /// </summary>
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0 ) return false;
            
            while (n % 2 == 0)
            {
                n /= 2;
            }

            return n == 1;
        }
    }


    public class SolutionTests
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(16, true)]
        [InlineData(3, false)]
        [InlineData(134217727, false)]
        public void IsPowerOfTwo_ShouldReturnExpectedResult(int n, bool IsPowerOfTwo)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsPowerOfTwo(n);

            // Assert
            Assert.Equal(IsPowerOfTwo, result);
        }
    }
}
