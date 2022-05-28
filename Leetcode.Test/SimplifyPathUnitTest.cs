// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class SimplifyPathUnitTest
{
    private readonly Solution _solution;
    public SimplifyPathUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData("/home/", "/home")]
    [InlineData("/../", "/")]
    [InlineData("/home//foo/", "/home/foo")]
    [InlineData("/a/./b/../../c/", "/c")]
    public void Test(string path, string expected)
    {

        string actual = _solution.SimplifyPath(path);
        Assert.Equal(expected, actual);
    }
}
