using Xunit;

namespace Training.LeetCode.IfWordOccursAsPrefix
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/description/
    /// </summary>
    public class Solution
    {
        /// <summary>
        ///
        /// Example 1:
        /// Input: sentence = "i love eating burger", searchWord = "burg"
        /// Output: 4
        /// Explanation: "burg" is prefix of "burger" which is the 4th word in the sentence.
        /// 
        /// <br/>
        ///  
        /// Example 2:
        /// Input: sentence = "this problem is an easy problem", searchWord = "pro"
        /// Output: 2
        /// Explanation: "pro" is prefix of "problem" which is the 2nd and the 6th word in the sentence, but we return 2 as it's the minimal index.
        /// 
        /// <br/>
        /// 
        /// Example 3:
        /// Input: sentence = "i am tired", searchWord = "you"
        /// Output: -1
        /// Explanation: "you" is not a prefix of any word in the sentence.
        ///
        /// <br/>
        /// 
        /// Status: "Accepted"
        /// 
        /// </summary>
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            var words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith(searchWord))
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }
    public class SolutionTest
    {

        [Theory]
        [InlineData("i love eating burger", "burg", 4)]
        [InlineData("this problem is an easy problem", "pro", 2)]
        [InlineData("i am tired", "you", -1)]
        [InlineData("hellohello hellohellohello", "ell", -1)]
        public void IsPrefixOfWord_ShouldReturnIndexOfPrefix(string sentence, string searchWord, int expectedIndex)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsPrefixOfWord(sentence, searchWord);

            // Assert
            Assert.Equal(expectedIndex, result);
        }
    }
}
