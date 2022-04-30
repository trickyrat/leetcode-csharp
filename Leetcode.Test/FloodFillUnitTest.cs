// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test
{
    public class FloodFillUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new int[][]
                {
                    new int[] { 1, 1, 1 },
                    new int[] { 1, 1, 0 },
                    new int[] { 1, 0, 1 },
                },
                1,
                1,
                2,
                new int[][]
                {
                    new int[] { 2, 2, 2 },
                    new int[] { 2, 2, 0 },
                    new int[] { 2, 0, 1 },
                }
            };
            yield return new object[]
            {
                new int[][]
                {
                    new int[] { 0, 0, 0 },
                    new int[] { 0, 0, 0 }
                },
                0,
                0,
                2,
                new int[][]
                {
                    new int[] { 2, 2, 2 },
                    new int[] { 2, 2, 2 }
                }
            };
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(int[][] input, int sr, int sc, int newColor, int[][] expected)
        {
            Solution solution = new Solution();
            int[][] actual = solution.FloodFill(input, sr, sc, newColor);
            Assert.Equal(expected, actual);
        }
    }
}
