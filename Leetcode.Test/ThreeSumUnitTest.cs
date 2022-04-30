// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Leetcode.Test
{
    public class ThreeSumUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new int[] { -1, 0, 1, 2, -1, -4 },
                new int[][] 
                {
                    new int[] { -1, -1, 2 },
                    new int[] { -1, 0, 1 }
                }
            };

            yield return new object[]
            {
                new int[]{ },
                new int[][]{}
            };

            yield return new object[]
            {
                new int[] { 0 },
                new int[][]{}
            };
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void MultipleDataTest(int[] nums, IList<IList<int>> expected)
        {
            Solution solution = new Solution();
            var actual = solution.ThreeSum(nums);
            Assert.Equal(expected, actual);
        }
    }
}