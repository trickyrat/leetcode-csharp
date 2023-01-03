// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class PushDominoesUnitTest
{
    private readonly Solution _solution;
    public PushDominoesUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData("RR.L", "RR.L")]
    [InlineData(".L.R...LR..L..", "LL.RR.LLRRLL..")]
    public void Test(string input, string expected)
    {

        var actual = _solution.PushDominoes(input);
        Assert.Equal(expected, actual);
    }
}
