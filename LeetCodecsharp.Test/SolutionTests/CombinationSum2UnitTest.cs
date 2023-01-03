// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace LeetCode.Test.SolutionTests
{
    public class CombinationSum2UnitTest
    {
        private readonly Solution _solution;

        public CombinationSum2UnitTest()
        {
            _solution = new Solution();
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new int[]{ 10, 1, 2, 7, 6, 1, 5 },
                8,
                new List<IList<int>>
                {
                    new List<int> { 2, 6 },
                    new List<int> { 1, 7 },
                    new List<int> { 1, 2, 5 },
                    new List<int> { 1, 1, 6 },
                }
            };

            yield return new object[]
            {
                new int[]{ 2, 5, 2, 1, 2 },
                5,
                new List<IList<int>>
                {
                    new List<int> { 5 },
                    new List<int> { 1, 2, 2 }
                }
            };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void MultipleDataTest(int[] candidates, int target, IList<IList<int>> expected)
        {
            var actual = _solution.CombinationSum2(candidates, target);
            Assert.Equal(expected, actual);
        }

    }
}