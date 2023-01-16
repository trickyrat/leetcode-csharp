// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests
{
    public class NearestValidPointUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                3,
                4,
                new int[][]
                {
                    new int[] { 1, 2 },
                    new int[] { 3, 1 },
                    new int[] { 2, 4 },
                    new int[] { 2, 3 },
                    new int[] { 4, 4 },
                },
                2
            };
            yield return new object[]
            {
                3,
                4,
                new int[][]
                {
                    new int[] { 3, 4 }
                },
                0
            };
            yield return new object[]
            {
                3,
                4,
                new int[][]
                {
                    new int[] { 2, 3 }
                },
                -1
            };
        }

        private readonly Solution _solution;

        public NearestValidPointUnitTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void MultipleDataTest(int x, int y, int[][] points, int expected)
        {
            var actual = _solution.NearestValidPoint(x, y, points);
            Assert.Equal(expected, actual);
        }
    }
}