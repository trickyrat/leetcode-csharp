// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MostCommonWordUnitTest
{
    private readonly Solution _solution;

    public MostCommonWordUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" }, "ball")]
    public void Test(string paragraph, string[] banned, string expected)
    {

        var actual = _solution.MostCommonWord(paragraph, banned);
        Assert.Equal(expected, actual);
    }

}