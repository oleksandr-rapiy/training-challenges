using Xunit;

namespace Training.LeetCode.TwoSum
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/two-sum/
    /// 
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// Example 1:
        /// Input: nums = [2, 7, 11, 15], target = 9
        /// Output: [0, 1]
        /// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        /// 
        /// <br/>
        /// 
        /// Example 2:
        /// Input: nums = [3, 2, 4], target = 6
        /// Output: [1, 2]
        /// 
        /// <br/>
        /// 
        /// Example 3:
        /// Input: nums = [3, 3], target = 6
        /// Output: [0, 1]
        /// 
        /// <br/>
        /// 
        /// Status: "Accepted"
        /// 
        /// </summary>
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new List<int>();

            for (int index = 0; index < nums.Length; index++)
            {
                for (int j = index + 1; j < nums.Length; j++)
                {
                    var sum = nums[index] + nums[j];
                    if (sum == target)
                    {
                        result.Add(index);
                        result.Add(j);
                    }
                }
            }

            return [.. result];
        }
    }

    public class SolutionTests
    {
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void TwoSum_ReturnValidIndexes(int[] nums, int target, int[] expectedResult)
        {
            // Arrange
            var solution = new Solution();
            // Act 
            var result = solution.TwoSum(nums, target);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
