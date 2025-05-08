using System.Text.RegularExpressions;
using Xunit;

namespace Training.LeetCode.LengthOfLastWord
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/length-of-last-word/description/
    /// 
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// Example 1:
        /// Input: s = "Hello World"
        /// Output: 5
        /// Explanation: The last word is "World" with length 5.
        ///
        /// <br/>
        /// 
        /// Example 2:
        /// Input: s = "   fly me   to   the moon  "
        /// Output: 4
        /// Explanation: The last word is "moon" with length 4.
        /// 
        /// <br/>
        /// 
        /// Example 3:
        /// Input: s = "luffy is still joyboy"
        /// Output: 6
        /// Explanation: The last word is "joyboy" with length 6.
        /// 
        /// <br/>
        /// 
        /// Status: "Accepted"
        /// 
        /// </summary>
        public int LengthOfLastWord(string s)
        {
            var str = Regex.Replace(s, @"\s+", " ").TrimStart().TrimEnd();

            var arr = str.Split(" ");

            return arr[arr.Count() - 1].Length;
        }
    }

    public class SolutionTests
    {
        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        public void LengthOfLastWord_ShouldReturnExpectedPrefix(string strs, int expectedLength)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.LengthOfLastWord(strs);

            // Assert
            Assert.Equal(expectedLength, result);
        }
    }
}
