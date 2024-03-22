// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests
{
    public class CalculateMinimumHpUnitTest
    {
        public static TheoryData<int[][], int> Data
        {
            get
            {
                var data = new TheoryData<int[][], int>
                {
                    {
                        [[-2, -3, 3], [-5, -10, 1], [10, 30, -5]], 7
                    },
                    {
                        [[0]], 1
                    }
                };
                return data;
            }
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void MultipleDataTest(int[][] dungeon, int expected)
        {
            var actual = Solution.CalculateMinimumHP(dungeon);
            Assert.Equal(expected, actual);
        }
    }
}