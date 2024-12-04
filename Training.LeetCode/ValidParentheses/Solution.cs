using Xunit;

namespace Training.LeetCode.ValidParentheses
{

    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/valid-parentheses/
    /// 
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// Example 1:
        /// Input: s = "()"
        /// Output: true
        /// 
        /// <br/>
        /// 
        /// Example 2:
        /// Input: s = "()[]{}"
        /// Output: true
        /// 
        /// <br/>
        /// 
        /// Example 3:
        /// Input: s = "(]"
        /// Output: false
        ///
        /// <br/>
        /// 
        /// Example 4:
        /// Input: s = "([])"
        /// Output: true
        /// 
        /// <br/>
        /// 
        /// Status: "Accepted"
        /// 
        /// </summary>
        /// 
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            var openPairs = new Dictionary<char, char>()
            {
                {'(', ')' },
                {'{', '}' },
                {'[', ']' }
            };

            var closePairs = new Dictionary<char, char>()
            {
                {')', '(' },
                {'}', '{' },
                {']', '[' }
            };

            foreach (var c in s)
            {
                if (openPairs.ContainsKey(c))
                {
                    stack.Push(c);
                }

                if (closePairs.TryGetValue(c, out var open))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var topStack = stack.Pop();

                    if (topStack != open)
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }

    public class SolutionTests
    {
        [Theory]
        [InlineData("]", false)]
        [InlineData("((", false)]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([])", true)]
        public void IsValid_ReturnIsParenthesesValid(string s, bool expectedResult)
        {
            // Arrange
            var solution = new Solution();
            // Act 
            var result = solution.IsValid(s);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
