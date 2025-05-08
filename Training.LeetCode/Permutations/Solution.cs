using Xunit;

namespace Training.LeetCode.Permutations
{
    /// <summary>
    /// LeetCode link: https://leetcode.com/problems/permutations/description/
    /// </summary>
    public class Solution
    {
        /// <summary>
        ///
        /// Example 1:
        /// Input: nums = [1,2,3]
        /// Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
        ///
        /// <br/>
        /// 
        /// Example 2:
        /// Input: nums = [0,1]
        /// Output: [[0,1],[1,0]]
        /// 
        /// <br/>
        /// 
        /// Example 3:
        /// Input: nums = [1]
        /// Output: [[1]]
        /// 
        /// Status: ""
        /// 
        /// </summary>
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>()
            {
                nums
            };


            


            return result;
        }
    }
    public class SolutionTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, "1,2,3; 1,3,2; 2,1,3; 2,3,1; 3,1,2; 3,2,1")]
        [InlineData(new int[] { 0, 1 }, "0,1; 1,0")]
        [InlineData(new int[] { 1 }, "1")]
        public void Permute_ShoudReturnValidPermutations(int[] nums, string expectedArray)
        {
            // Arrange
            var expected = ParseExpectedArray(expectedArray);
            var solution = new Solution();

            // Act
            var result = solution.Permute(nums);

            // Assert
            Assert.Equal(expected, result);
        }


        private IList<IList<int>> ParseExpectedArray(string expectedArray)
        {
            var result = new List<IList<int>>();
            var arrays = expectedArray.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var array in arrays)
            {
                var numbers = array.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToList();
                result.Add(numbers);
            }
            return result;
        }
    }
}
