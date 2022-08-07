// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class ReverseIntegerUnitTest
{
    private readonly Solution _solution;
    public ReverseIntegerUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(0, 0)]
    public void MultipleDataTest(int input, int expected)
    {
        
        int actual = _solution.Reverse(input);
        Assert.Equal(expected, actual);
    }
}