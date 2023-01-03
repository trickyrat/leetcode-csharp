using System.Collections.Generic;
using Xunit;

namespace LeetCode.Test.SolutionTests;

public class MaxLengthBetweenEqualCharactersUnitTest
{
    private readonly Solution _solution;

    public MaxLengthBetweenEqualCharactersUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("aa", 0)]
    [InlineData("abca", 2)]
    [InlineData("cbzyx", -1)]
    public void Test(string s, int expected)
    {
        var actual = _solution.MaxLengthBetweenEqualCharacters(s);
        Assert.Equal(expected, actual);
    }

}