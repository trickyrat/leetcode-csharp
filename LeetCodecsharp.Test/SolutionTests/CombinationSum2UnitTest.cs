// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests
{
    public class CombinationSum2UnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return
            [
                new []{ 10, 1, 2, 7, 6, 1, 5 },
                8,
                new List<IList<int>>
                {
                    new List<int> { 2, 6 },
                    new List<int> { 1, 7 },
                    new List<int> { 1, 2, 5 },
                    new List<int> { 1, 1, 6 },
                }
            ];

            yield return
            [
                new []{ 2, 5, 2, 1, 2 },
                5,
                new List<IList<int>>
                {
                    new List<int> { 5 },
                    new List<int> { 1, 2, 2 }
                }
            ];
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void MultipleDataTest(int[] candidates, int target, IList<IList<int>> expected)
        {
            var actual = Solution.CombinationSum2(candidates, target);
            Assert.Equal(expected, actual);
        }

    }
}