// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class ReformatNumberUnitTest
{
    private readonly Solution _solution;

    public ReformatNumberUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData("1-23-45 6", "123-456")]
    [InlineData("123 4-567", "123-45-67")]
    [InlineData("123 4-5678", "123-456-78")]
    public void MultipleDataTest(string number, string expected)
    {
        var actual = _solution.ReformatNumber(number);
        Assert.Equal(expected, actual);
    }
}

