// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class ReverseIntegerUnitTest
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(0, 0)]
    public void MultipleDataTest(int input, int expected)
    {

        var actual = Solution.ReverseInteger(input);
        Assert.Equal(expected, actual);
    }
}