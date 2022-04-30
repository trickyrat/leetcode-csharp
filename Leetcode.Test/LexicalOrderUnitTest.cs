// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test
{
    public class LexicalOrderUnitTest
    {
        [Theory]
        [InlineData(13, new int[] { 1, 10, 11, 12, 13, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [InlineData(2, new int[] { 1, 2 })]
        public void MultipleDataTest(int n, IList<int> expected)
        {
            Solution solution = new Solution();
            IList<int> actual = solution.LexicalOrder(n);
            Assert.Equal(expected, actual);
        }
    }
}