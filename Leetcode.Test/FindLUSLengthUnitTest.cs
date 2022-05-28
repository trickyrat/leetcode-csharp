// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class FindLUSLengthUnitTest
{
    private readonly Solution _solution;

    public FindLUSLengthUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("aba", "cdc", 3)]
    [InlineData("aaa", "bbb", 3)]
    [InlineData("aaa", "aaa", -1)]
    public void MultipleDataTest(string a, string b, int expected)
    {
        int actual = _solution.FindLUSLength(a, b);
        Assert.Equal(expected, actual);
    }
}