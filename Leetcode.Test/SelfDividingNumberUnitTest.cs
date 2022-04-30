// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;

using Xunit;

namespace Leetcode.Test
{
    public class SelfDividingNumberUnitTest
    {
        [Theory]
        [InlineData(1, 22, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 })]
        [InlineData(47, 85, new int[] { 48, 55, 66, 77 })]
        public void MultipleDataTest(int left, int right, int[] expected)
        {
            Solution solution = new Solution();
            IList<int> actual = solution.SelfDividingNumbers(left, right);
            Assert.Equal(expected, actual.ToArray());
        }

    }
}