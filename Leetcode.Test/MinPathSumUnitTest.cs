// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class MinPathSumUnitTest
    {

        [Fact]
        public void MinPathSumTest1()
        {
            int[][] grid = new int[3][]
                {
                     new int[]{ 1,2,3,1},
                     new int[]{ 4,5,6,1},
                     new int[]{ 7,8,9,1}
                };
            int actual = Solution.MinPathSum(grid);
            int expected = 9;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MinPathSumTest2()
        {
            int[][] grid = new int[3][]
                {
                     new int[]{ 1,2,3,1},
                     new int[]{ 4,2,6,1},
                     new int[]{ 7,1,1,1}
                };
            int actual = Solution.MinPathSum(grid);
            int expected = 8;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MinPathSumTest3()
        {
            int[][] grid = new int[3][]
                {
                     new int[]{ 1,1,1,1},
                     new int[]{ 1,1,1,1},
                     new int[]{ 1,1,1,1}
                };
            int actual = Solution.MinPathSum(grid);
            int expected = 6;

            Assert.Equal(expected, actual);
        }

    }
}
