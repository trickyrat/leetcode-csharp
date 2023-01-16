// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests
{
    public class LargestPerimeterUnitTest
    {
        private readonly Solution _solution;

        public LargestPerimeterUnitTest()
        {
            _solution = new Solution();
        }


        [Theory]
        [InlineData(new int[] { 2, 1, 2 }, 5)]
        [InlineData(new int[] { 1, 2, 1 }, 0)]
        public void MultipleDataTest(int[] nums, int expected)
        {
            var actual = _solution.LargestPerimeter(nums);
            Assert.Equal(expected, actual);
        }

    }
}