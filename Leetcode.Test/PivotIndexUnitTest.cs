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
    public class PivotIndexUnitTest
    {

        [Theory]
        [InlineData(new int[] { 2, 3, -1, 8, 4 }, 3)]
        [InlineData(new int[] { 1, -1, 4 }, 2)]
        [InlineData(new int[] { 2, 5 }, -1)]
        public void MultipleDataTest(int[] nums, int expect)
        {
            Solution solution = new Solution();
            int actual = solution.PivotIndex(nums);
            Assert.Equal(expect, actual);
        }
    }
}