// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class PowerOfTwoUnitTest
{
    private readonly Solution _solution;
    public PowerOfTwoUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(1, true)]
    [InlineData(16, true)]
    [InlineData(4, true)]
    [InlineData(3, false)]
    public void Test(int num, bool expected)
    {

        var actual = _solution.IsPowerOfTwo(num);
        Assert.Equal(expected, actual);
    }
}
