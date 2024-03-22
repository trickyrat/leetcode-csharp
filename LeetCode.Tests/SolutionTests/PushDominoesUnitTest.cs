// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class PushDominoesUnitTest
{
    [Theory]
    [InlineData("RR.L", "RR.L")]
    [InlineData(".L.R...LR..L..", "LL.RR.LLRRLL..")]
    public void Test(string input, string expected)
    {

        var actual = Solution.PushDominoes(input);
        Assert.Equal(expected, actual);
    }
}
