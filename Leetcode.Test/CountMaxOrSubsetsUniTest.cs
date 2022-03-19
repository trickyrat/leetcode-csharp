// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class CountMaxOrSubsetsUniTest
    {

        [Theory]
        [InlineData(new int[] { 3, 1 }, 2)]
        [InlineData(new int[] { 2, 2, 2 }, 7)]
        [InlineData(new int[] { 3, 2, 1, 5 }, 6)]
        public void MultipleDataTest(int[] input, int expect)
        {
            int actual = Solution.CountMaxOrSubsets(input);
            Assert.Equal(expect, actual);
        }
    }
}