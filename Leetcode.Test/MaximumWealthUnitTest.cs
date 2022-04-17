// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test
{
    public class MaximumWealthUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new int[][]
                {
                    new int[]{ 1,2,3},
                    new int[]{ 3,2,1}
                },
                6
            };
            yield return new object[]
            {
                new int[][]
                {
                    new int[]{ 1,5},
                    new int[]{ 7,3},
                    new int[]{ 3,5}
                },
                10
            };
            yield return new object[]
            {
                new int[][]
                {
                    new int[]{ 2,8,7},
                    new int[]{ 7,1,3},
                    new int[]{ 1,9,5},
                },
               17
            };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void MultipleDataTest(int[][] accounts, int expected)
        {
            int actual = Solution.MaximumWealth(accounts);
            Assert.Equal(expected, actual);
        }
    }
}