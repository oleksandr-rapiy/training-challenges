using Xunit;

namespace Training.LeetCode.LongestCommonPrefix
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/longest-common-prefix/description/
    /// 
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// Example 1:
        /// Input: strs = ["flower", "flow", "flight"]
        /// Output: "fl"
        /// 
        /// <br/>
        /// 
        /// Example 2:
        /// Input: strs = ["dog", "racecar", "car"]
        /// Output: ""
        /// 
        /// <br/>
        /// 
        /// Status: "Accepted"
        /// 
        /// </summary>
        public string LongestCommonPrefix(string[] strs)
        {
            var result = string.Empty;

            if (strs.Length == 1)
            {
                return strs[0];
            }

            for (int i = 0; i <= strs[0].ToCharArray().Length - 1; i++)
            {
                var subString = strs[0][..(i + 1)];

                foreach (var str in strs)
                {
                    if (i >= str.Length) return result;
                    var tempSubstring = str[..(i + 1)];
                    if (subString != tempSubstring)
                        return result;
                }

                result = subString;
            }

            return result;
        }
    }


    public class SolutionTests
    {
        [Theory]
        [InlineData(new[] { "a" }, "a")]
        [InlineData(new[] { "ab", "a" }, "a")]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "flower", "flower", "flower", "flower" }, "flower")]
        public void LongestCommonPrefix_ShouldReturnExpectedPrefix(string[] strs, string expectedPrefix)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.LongestCommonPrefix(strs);

            // Assert
            Assert.Equal(expectedPrefix, result);
        }
    }
}
