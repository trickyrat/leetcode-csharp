// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class FindSubstringInWraparoundStringUnitTest
{
    private readonly Solution _solution;

    public FindSubstringInWraparoundStringUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("a", 1)]
    [InlineData("cac", 2)]
    [InlineData("zab", 6)]
    public void Test(string p, int expected)
    {
        int actual = _solution.FindSubstringInWraparoundString(p);
        Assert.Equal(expected, actual);
    }
}