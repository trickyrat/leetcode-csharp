// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests
{
    public class CalculateMinimumHpUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return
            [
                new[]
                {
                    new[] { -2, -3, 3 },
                    new[] { -5, -10, 1 },
                    new[] { 10, 30, -5 },
                },
                7
            ];
            yield return
            [
                new[]
                {
                    new[] { 0 }
                },
                1
            ];
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void MultipleDataTest(int[][] dungeon, int expected)
        {
            var actual = Solution.CalculateMinimumHP(dungeon);
            Assert.Equal(expected, actual);
        }
    }
}