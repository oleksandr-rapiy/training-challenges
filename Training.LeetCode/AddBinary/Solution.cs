using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace Training.LeetCode.AddBinary
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/add-binary/description/
    /// 
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// Example 1:
        /// Input: a = "11", b = "1"
        /// Output: "100"
        /// 
        /// <br/>
        /// 
        /// Example 2:
        /// Input: a = "1010", b = "1011"
        /// Output: "10101"
        /// 
        /// <br/>
        /// 
        /// Status: ""
        /// 
        /// </summary>
        public string AddBinary(string a, string b)
        {

        }
    }

    public class SolutionTests
    {
        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        [InlineData(
            "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101",
            "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011", "10101")]
        public void AddBinary_ShouldReturnExpectedPrefix(string a, string b, string expectedResult)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.AddBinary(a, b);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
