using Xunit;

namespace Training.LeetCode.CheckIfExist
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/check-if-n-and-its-double-exist/
    /// </summary>
    public class Solution
    {
        /// <summary>
        ///
        /// Example 1:
        /// Input: arr = [10, 2, 5, 3]
        /// Output: true
        /// Explanation: For i = 0 and j = 2, arr[i] == 10 == 2 * 5 == 2 * arr[j]
        /// 
        /// <br/>  
        /// 
        /// Example 2:
        /// Input: arr = [3, 1, 7, 11]
        /// Output: false
        /// Explanation: There is no i and j that satisfy the conditions.
        /// 
        /// <br/>
        /// 
        /// Status: "Accepted"
        /// 
        /// </summary>
        public bool CheckIfExist(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j >= 0; j--)
                {
                    if (i != j && arr[i] == 2 * arr[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }

    public class SolutionTest
    {

        [Theory]
        [InlineData(new[] { 10, 2, 5, 3 }, true)]
        [InlineData(new[] { 3, 1, 7, 11 }, false)]
        [InlineData(new[] { -2, 0, 10, -19, 4, 6, -8 }, false)]
        public void CheckIfExist_ShouldReturnExpectedResult(int[] arr, bool expectedResult)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.CheckIfExist(arr);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
