// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class CountSegmentUnitTest
    {
        [Theory]
        [InlineData("Hello, my name is John", 5)]
        [InlineData("Hello", 1)]
        [InlineData("love live! mu'sic forever", 4)]
        [InlineData("", 0)]
        public void Test(string s, int count)
        {
            int actual = Solution.CountSegments(s);
            int expected = count;
            Assert.Equal(expected, actual);
        }
    }
}
