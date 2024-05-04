﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class SimplifyPathUnitTest
{
    [Theory]
    [InlineData("/home/", "/home")]
    [InlineData("/../", "/")]
    [InlineData("/home//foo/", "/home/foo")]
    [InlineData("/a/./b/../../c/", "/c")]
    public void Test(string path, string expected)
    {
        var actual = Solution.SimplifyPath(path);
        Assert.Equal(expected, actual);
    }
}