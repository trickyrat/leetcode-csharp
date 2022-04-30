// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class MinRemoveToMakeValidUnitTest
    {

        [Theory]
        [InlineData("lee(t(c)o)de)", "lee(t(c)o)de")]
        [InlineData("a)b(c)d", "ab(c)d")]
        [InlineData("))((", "")]
        public void MultipleDataTest(string testInput, string expected)
        {
            Solution solution = new Solution();
            string actual = solution.MinRemoveToMakeValid(testInput);
            Assert.Equal(expected, actual);
        }
    }
}