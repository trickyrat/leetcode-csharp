// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class BackspaceCompareUnitTest
    {
        [Theory]
        [InlineData("ab#c", "ad#c", true)]
        [InlineData("ab##", "c#d#", true)]
        [InlineData("a##c", "#a#c", true)]
        [InlineData("a#c", "b", false)]
        public void Test(string s, string t, bool expected)
        {
            Solution solution = new Solution();
            bool actual = solution.BackspaceCompare(s, t);
            Assert.Equal(expected, actual);
        }
    }
}
