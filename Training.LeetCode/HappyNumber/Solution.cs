using Xunit;

namespace Training.LeetCode.HappyNumber
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/happy-number/description/
    /// 
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// Example 1:
        /// Input: n = 19
        /// Output: true
        /// Explanation:
        /// 1^2 + 9^2 = 82
        /// 8^2 + 2^2 = 68
        /// 6^2 + 8^2 = 100
        /// 1^2 + 0^2 + 0^2 = 1
        /// 
        /// <br/>
        /// 
        /// Example 2:
        /// Input: n = 2
        /// Output: false
        /// 
        /// <br/>
        /// 
        /// Status: "Accepted"
        /// 
        /// </summary>
        public bool IsHappy(int n)
        {
            if (n < 10 && n % 2 == 0) return false;

            var nums = new List<int>();

            while (n > 0)
            {
                nums.Add(n % 10);
                n /= 10;
            }

            var sum = 0;
            foreach (var x in nums)
            {
                sum += x * x;
            }

            if (sum == 1) return true;

            return IsHappy(sum);
        }
    }


    public class SolutionTests
    {
        [Theory]
        [InlineData(19, true)]
        [InlineData(1, true)]
        [InlineData(7, true)]
        [InlineData(3, false)]
        [InlineData(10, true)]
        public void IsHappy_ShouldReturnExpectedResult(int n, bool isHappy)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsHappy(n);

            // Assert
            Assert.Equal(isHappy, result);
        }
    }
}
