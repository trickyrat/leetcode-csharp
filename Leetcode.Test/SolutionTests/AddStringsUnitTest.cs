// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class AddStringsUnitTest
{
    private readonly Solution _solution;
    public AddStringsUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData("1345", "8656", "10001")]
    [InlineData("245", "356", "601")]
    [InlineData("999", "1231", "2230")]
    public void AddStringsTest1(string num1, string num2, string expected)
    {
        var actual = _solution.AddStrings(num1, num2);
        Assert.Equal(expected, actual);
    }
}
