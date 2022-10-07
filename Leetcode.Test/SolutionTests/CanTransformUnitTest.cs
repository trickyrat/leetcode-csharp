// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;
public class CanTransformUnitTest
{
    private readonly Solution _solution;

    public CanTransformUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("RXXLRXRXL", "XRLXXRRLX", true)]
    [InlineData("R", "L", false)]
    public void MultipleDataTest(string start, string end, bool expected)
    {
        var actual = _solution.CanTransform(start, end);
        Assert.Equal(expected, actual);
    }
}

