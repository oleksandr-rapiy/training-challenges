using System.Numerics;
using Xunit;

namespace Training.LeetCode.PlusOne
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/plus-one/description/
    /// </summary>
    public class Solution
    {
        /// <summary>
        ///
        /// Example 1:
        /// Input: digits = [1, 2, 3]
        /// Output: [1, 2, 4]
        /// Explanation: The array represents the integer 123.
        /// Incrementing by one gives 123 + 1 = 124.
        /// Thus, the result should be[1, 2, 4].
        /// 
        /// <br/>
        ///
        /// Example 2:
        /// Input: digits = [4, 3, 2, 1]
        /// Output: [4, 3, 2, 2]
        /// Explanation: The array represents the integer 4321.
        /// Incrementing by one gives 4321 + 1 = 4322.
        /// Thus, the result should be[4, 3, 2, 2].
        /// 
        /// <br/>
        /// 
        /// Example 3:
        /// Input: digits = [9]
        /// Output: [1, 0]
        /// Explanation: The array represents the integer 9.
        /// Incrementing by one gives 9 + 1 = 10.
        /// Thus, the result should be[1, 0].
        ///
        /// <br/>
        /// 
        /// Status: "Accepted"
        /// 
        /// </summary>
        public int[] PlusOne(int[] digits)
        {
            var str = string.Join("", digits);

            // kinda stupid and inefficient solution
            var number = BigInteger.Parse(str);
            ++number;

            var result = number.ToString().Select(x => int.Parse(x.ToString()));

            return result.ToArray();
        }
    }

    public class SolutionTest
    {

        [Theory]
        [InlineData(new[] { 9 }, new[] { 1, 0 })]
        [InlineData(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
        public void PlusOne_ShouldReturnExpectedResult(int[] digits, int[] expectedResult)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.PlusOne(digits);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
