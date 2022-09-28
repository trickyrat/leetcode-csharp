// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class GetSumUnitTest
{
    private readonly Solution _solution;
    public GetSumUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(7, 3, 10)]
    [InlineData(1, -2, -1)]
    public void Test_Should_OK(int a, int b, int expected)
    {

        var actual = _solution.GetSum(a, b);
        Assert.Equal(expected, actual);
    }
}
