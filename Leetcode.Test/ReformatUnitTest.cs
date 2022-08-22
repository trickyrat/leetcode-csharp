// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;
public class ReformatUnitTest
{
    private readonly Solution _solution;

    public ReformatUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData("a0b1c2", "a0b1c2")]
    [InlineData("leetcode", "")]
    [InlineData("1229857369", "")]
    public void MultipleDataTest(string input, string expected)
    {
        string actual = _solution.Reformat(input);
        Assert.Equal(expected, actual);
    }
}

