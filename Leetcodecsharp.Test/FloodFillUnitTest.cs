// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class FloodFillUnitTest
    {
        [Fact]
        public void Test_Input_One_Corner_Should_OK()
        {
            int[][] image = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 },
            };
            int[][] actual = Solution.FloodFill(image, 1, 1, 2);
            int[][] expected = new int[][]
            {
                new int[] { 2, 2, 2 },
                new int[] { 2, 2, 0 },
                new int[] { 2, 0, 1 },
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_All_Zero_Should_OK()
        {
            int[][] image = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 },
            };
            int[][] actual = Solution.FloodFill(image, 0, 0, 2);
            int[][] expected = new int[][]
            {
                new int[] { 2, 2, 2 },
                new int[] { 2, 2, 2 },
            };
            Assert.Equal(expected, actual);
        }
    }
}
