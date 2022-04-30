// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class SimplifyPathUnitTest
    {
        [Theory]
        [InlineData("/home/", "/home")]
        [InlineData("/../", "/")]
        [InlineData("/home//foo/", "/home/foo")]
        [InlineData("/a/./b/../../c/", "/c")]
        public void Test(string path, string expected)
        {
            Solution solution = new Solution();
            string actual = solution.SimplifyPath(path);
            Assert.Equal(expected, actual);
        }
    }
}
