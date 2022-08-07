// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class ConvertToTitle
{
    private readonly Solution _solution;

    public ConvertToTitle()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(1, "A")]
    [InlineData(28, "AB")]
    [InlineData(701, "ZY")]
    public void MultipleDataTest(int columnNumber, string expected)
    {
        string actual = _solution.ConvertToTitle(columnNumber);
        Assert.Equal(expected, actual);
    }
}